using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmDeleteAnimal : Form
    {
        public frmDeleteAnimal()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();

            if (dgvDeleteDisplay.CurrentRow == null)
            {
                MessageBox.Show("Please select a row first", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = dgvDeleteDisplay.CurrentRow.Cells[0].Value?.ToString();
            string name = dgvDeleteDisplay.CurrentRow.Cells[1].Value?.ToString();


            if (string.IsNullOrEmpty(id))
            {
                return;
            }

            var confirm = MessageBox.Show($"Delete {id} ({name})? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = dth.DeleteAnimal(id);

                if (deleted)
                {
                    MessageBox.Show("Animal deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<Animal> animals = dth.LoadAnimals().Animals;
                    BindingSource binding = new BindingSource();
                    binding.DataSource = animals;
                    dgvDeleteDisplay.DataSource = binding;
                }
                else
                {
                    MessageBox.Show($"Animal with id {id} could not be found", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmDeleteAnimal_Load(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();

            List<Animal> animals = dth.LoadAnimals().Animals;
            BindingSource binding = new BindingSource();
            binding.DataSource = animals;
            dgvDeleteDisplay.DataSource = binding;
        }
    }
}
