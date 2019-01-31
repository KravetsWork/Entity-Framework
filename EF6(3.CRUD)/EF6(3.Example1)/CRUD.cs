using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace EF6_3.Example1_
{
    public partial class CRUD : Form
    {
        // Read
        SoccerContext db;
        public CRUD()
        {
            InitializeComponent();

            db = new SoccerContext();
            db.Players.Load();

            dataGridView1.DataSource = db.Players.Local.ToBindingList();
        }

        // Create
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            DialogResult result = playerForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Player player = new Player();
            player.Age = (int)playerForm.numericUpDownAge.Value;
            player.Name = playerForm.textBoxName.Text;
            player.Position = playerForm.comboBoxPosition.SelectedItem.ToString();

            db.Players.Add(player);
            db.SaveChanges();
            MessageBox.Show("Player succesfully added");
        }

        // Update
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
                PlayerForm playerForm = new PlayerForm();

                playerForm.numericUpDownAge.Value = player.Age;
                playerForm.textBoxName.Text = player.Name;
                playerForm.comboBoxPosition.SelectedItem = player.Position;

                DialogResult result = playerForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                player.Age = (int)playerForm.numericUpDownAge.Value;
                player.Position = playerForm.comboBoxPosition.SelectedItem.ToString();
                player.Name = playerForm.textBoxName.Text;

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Player succesfully updated");
            }
        }

        // Delete
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

                MessageBox.Show("Player successfully deleted");
            }
        }
    }
}
