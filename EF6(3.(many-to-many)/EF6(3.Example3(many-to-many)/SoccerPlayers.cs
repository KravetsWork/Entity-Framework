using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace EF6_3.Example3_many_to_many_
{
    public partial class SoccerPlayers : Form
    {
        SoccerContext db;

        public SoccerPlayers()
        {
            InitializeComponent();

            db = new SoccerContext();
            db.Players.Load();
            dataGridView1.DataSource = db.Players.Local.ToBindingList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();

            List<Team> teams = db.Teams.ToList();
            playerForm.listBoxPastTeams.DataSource = teams;
            playerForm.listBoxPastTeams.ValueMember = "Id";
            playerForm.listBoxPastTeams.DisplayMember = "Name";

            DialogResult result = playerForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            Player player = new Player();
            player.Age = (int)playerForm.numericUpDownAge.Value;
            player.Name = playerForm.textBoxName.Text.ToString();

            teams.Clear();
            foreach (var item in playerForm.listBoxPastTeams.SelectedItems)
            {
                teams.Add((Team)item);
            }

            player.Teams = teams;
            db.Players.Add(player);
            db.SaveChanges();

            MessageBox.Show("New player was created");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Player player = db.Players.Find(id);

            PlayerForm playerForm = new PlayerForm();
            playerForm.textBoxName.Text = player.Name;
            playerForm.numericUpDownAge.Value = player.Age;

            List<Team> teams = db.Teams.ToList();
            playerForm.listBoxPastTeams.DataSource = teams;
            playerForm.listBoxPastTeams.ValueMember = "Id";
            playerForm.listBoxPastTeams.DisplayMember = "Name";
            foreach (Team t in player.Teams)
            {
                playerForm.listBoxPastTeams.SelectedItem = t;
            }

            DialogResult result = playerForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            player.Age = (int)playerForm.numericUpDownAge.Value;
            player.Name = playerForm.textBoxName.Text.ToString();

            foreach (var team in teams)
            {
                if (playerForm.listBoxPastTeams.SelectedItems.Contains(team))
                {
                    if (!player.Teams.Contains(team))
                        player.Teams.Add(team);
                }
                else
                {
                    if (!player.Teams.Contains(team))
                        player.Teams.Remove(team);
                }
            }

            db.Entry(player).State = EntityState.Modified;
            db.SaveChanges();

            MessageBox.Show("Player was updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();

            MessageBox.Show("Player was deleted");         
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            TeamForm tmForm = new TeamForm();

            DialogResult result = tmForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            Team team = new Team();
            team.Name = tmForm.textBoxTeamName.Text;
            team.Coach = tmForm.textBoxCoach.Text;
            team.Players = new List<Player>();

            db.Teams.Add(team);
            db.SaveChanges();

            MessageBox.Show("New team was added");
        }
    }
}
