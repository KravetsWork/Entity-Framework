using EF6_3.Example2_one_to_many_;
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

namespace EF6_3.Example2_one_to_much_
{
    public partial class FormTeam : Form
    {
        SoccerContext db;
        public FormTeam()
        {
            InitializeComponent();

            db = new SoccerContext();
            db.Teams.Load();
            dataGridView1.DataSource = db.Teams.Local.ToBindingList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCreateTeam createTeam = new FormCreateTeam();
            DialogResult result = createTeam.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Team team = new Team();
            team.Name = createTeam.textBoxTeamName.Text;
            team.Coach = createTeam.textBoxCoach.Text;

            db.Teams.Add(team);
            db.SaveChanges();

            MessageBox.Show("New object was added");
        }

        private void buttonStructure_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (convert == false)
                    return;

                //Team team = db.Teams.Find(id);
                var pl = db.Players.Where(p => p.TeamId == id);
                listBoxStructure.DataSource = pl.ToList();
                listBoxStructure.DisplayMember = "Name";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Team team = db.Teams.Find(id);
                team.Players.Clear();
                db.Teams.Remove(team);
                db.SaveChanges();

                MessageBox.Show("Object was deleted");
            }
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

                Team team = db.Teams.Find(id);

                FormCreateTeam createTeam = new FormCreateTeam();
                createTeam.textBoxTeamName.Text = team.Name;
                createTeam.textBoxCoach.Text = team.Coach;

                DialogResult result = createTeam.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                team.Name = createTeam.textBoxTeamName.Text;
                team.Coach = createTeam.textBoxCoach.Text;

                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Object was updated");
            }
        }
    }
}
