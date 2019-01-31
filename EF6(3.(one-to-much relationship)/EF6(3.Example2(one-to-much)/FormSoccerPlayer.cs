using EF6_3.Example2_one_to_much_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF6_3.Example2_one_to_many_
{
    public partial class FormSoccerPlayer : Form
    {
        SoccerContext db;
        public FormSoccerPlayer()
        {
            InitializeComponent();

            db = new SoccerContext();
            db.Players.Load();
            dataGridView1.DataSource = db.Players.Local.ToBindingList();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormPlayer playerForm = new FormPlayer();

            List<Team> teams = db.Teams.ToList();
            playerForm.comboBoxTeam.DataSource = teams;
            playerForm.comboBoxTeam.ValueMember = "Id";
            playerForm.comboBoxTeam.DisplayMember = "Name";

            DialogResult result = playerForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Player player = new Player();
            player.Name = playerForm.textBoxName.Text;
            player.Position = playerForm.comboBoxPosition.SelectedItem.ToString();
            player.Age = (int)playerForm.numericUpDownAge.Value;
            player.Team = (Team)playerForm.comboBoxTeam.SelectedItem;

            db.Players.Add(player);
            db.SaveChanges();

            MessageBox.Show("New soccer player was created");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (convert == false)
                    return;

                Player player = db.Players.Find(id);

                FormPlayer playerForm = new FormPlayer();
                playerForm.textBoxName.Text = player.Name;
                playerForm.numericUpDownAge.Value = player.Age;
                playerForm.comboBoxPosition.SelectedItem = player.Position;

                List<Team> teams = db.Teams.ToList();
                playerForm.comboBoxTeam.DataSource = teams;
                playerForm.comboBoxTeam.ValueMember = "Id";
                playerForm.comboBoxTeam.DisplayMember = "Name";

                if (player.Team != null)
                    playerForm.comboBoxTeam.SelectedValue = player.Team.Id;

                DialogResult result = playerForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                player.Name = playerForm.textBoxName.Text;
                player.Position = playerForm.comboBoxPosition.SelectedItem.ToString();
                player.Age = (int)playerForm.numericUpDownAge.Value;
                player.Team = (Team)playerForm.comboBoxTeam.SelectedItem;

                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Soccer player was updated");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (convert == false)
                    return;

                Player player = db.Players.Find(id);
                db.Players.Remove(player);
                db.SaveChanges();

                MessageBox.Show("Soccer player was deleted");
            }
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            FormTeam formTeam = new FormTeam();
            formTeam.Show();
        }
    }
}
