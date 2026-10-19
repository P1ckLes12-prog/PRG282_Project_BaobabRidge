using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmViewAnimals : Form
    {
        public frmViewAnimals()
        {
            InitializeComponent();
        }

        private void frmViewAnimals_Load(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            var result = handler.LoadAnimals();

            dgvViewAnimals.DataSource = result.Animals;

            dgvViewAnimals.ReadOnly = true;
            dgvViewAnimals.AllowUserToAddRows = false;
            dgvViewAnimals.AllowUserToDeleteRows = false;
            dgvViewAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (result.Skipped > 0)
            {
                MessageBox.Show($"{result.Skipped} invalid lines were skipped while loading.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
