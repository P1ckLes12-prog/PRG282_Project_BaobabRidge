using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmUpdateAnimal : Form
    {
        public frmUpdateAnimal()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();
            BindingSource bs = new BindingSource();

            string[] result = dth.UpdateAnimal(txtAnimalID.Text, txtName.Text, txtSpecies.Text, Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtRecoveryScore.Text));

            bs.DataSource = result;
            dgvDisp.DataSource = bs;

            MessageBox.Show("Animal updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDispAll_Click(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();
            List<Animal> animals = dth.LoadAnimals().Animals;
            BindingSource bs = new BindingSource();
            bs.DataSource = animals;
            dgvDisp.DataSource = bs;
        }

        private void dgvDisp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Make sure the user clicked a valid row (not the header)
            if (e.RowIndex < 0)
                return;

            // Get the selected row
            DataGridViewRow row = dgvDisp.Rows[e.RowIndex];

            // Put the values into the textboxes
            txtAnimalID.Text = row.Cells[0].Value?.ToString(); // AnimalID
            txtName.Text = row.Cells[1].Value?.ToString(); // Name
            txtSpecies.Text = row.Cells[2].Value?.ToString(); // Species
            txtAge.Text = row.Cells[3].Value?.ToString(); // Age
            txtRecoveryScore.Text = row.Cells[4].Value?.ToString(); // RecoveryScore
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
