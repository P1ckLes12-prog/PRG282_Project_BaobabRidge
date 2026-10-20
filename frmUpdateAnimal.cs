using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmUpdateAnimal : Form
    {
        private bool isEditMode = false;
        public frmUpdateAnimal()
        {
            InitializeComponent();
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
            txtAnimalID.Text = dgvDisp.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvDisp.CurrentRow.Cells[1].Value.ToString();
            txtSpecies.Text = dgvDisp.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = dgvDisp.CurrentRow.Cells[3].Value.ToString();
            txtRecoveryScore.Text = dgvDisp.CurrentRow.Cells[4].Value.ToString();

            SetEditMode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter an Animal ID.");

            }
            DataHandler handler = new DataHandler();
            List<Animal> animals = handler.LoadAnimals().Animals;

            Animal found = null;

            // Search with foreach
            foreach (Animal a in animals)
            {
                if (a.AnimalID.ToUpper() == id.ToUpper())
                {
                    found = a;
                    break;   // stop as soon as we find it
                }
            }

            if (found != null)
            {
                // Load the animal into the textboxes
                txtAnimalID.Text = found.AnimalID;
                txtName.Text = found.Name;
                txtSpecies.Text = found.Species;
                txtAge.Text = found.Age.ToString();
                txtRecoveryScore.Text = found.RecoveryScore.ToString();

                SetEditMode();
            }
            else
            {
                // Provide a friendly message instead of crashing
                MessageBox.Show("Animal not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          
        }

        private void frmUpdateAnimal_Load(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();
            dgvDisp.DataSource = dth.LoadAnimals().Animals;
        }


        private void SetEditMode()
        {
            isEditMode = true;
            txtAnimalID.ReadOnly = true;
            btnSaveChanges.Enabled = true;
            btnSearch.Enabled = false;
            // if you still have an Add button on this form, disable it:
            // btnAdd.Enabled = false;
        }

        private void SetAddMode()
        {
            isEditMode = false;
            txtAnimalID.ReadOnly = false;
            btnSaveChanges.Enabled = false;
            btnSearch.Enabled = true;
            // btnAdd.Enabled = true;
            ClearBoxes();
        }

        private void ClearBoxes()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
           if (!isEditMode)
            {
                MessageBox.Show("Please select or search for an animal first.", "No animal loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataHandler dth = new DataHandler();

            // ----- Validation (same rules as Add, except uniqueness) -----
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 30 || txtName.Text.Contains("|"))
            {
                MessageBox.Show("Name is required, 1–30 characters, and must not contain |.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecies.Text) || txtSpecies.Text.Length > 30 || txtSpecies.Text.Contains("|"))
            {
                MessageBox.Show("Species is required, 1–30 characters, and must not contain |.", "Invalid Species", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecies.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(txtRecoveryScore.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRecoveryScore.Focus();
                return;
            }

            try
            {
                string[] result = dth.UpdateAnimal(txtAnimalID.Text.ToUpper(), txtName.Text, txtSpecies.Text, Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtRecoveryScore.Text));
                BindingSource bs = new BindingSource();
                bs.DataSource = result;

                (string status, string housing) both = Animal.ClassifyRecoveryScore(score);

                string status = both.status;
                string housing = both.housing;
                MessageBox.Show($"Animal updated.\nStatus: {status}\nHousing Unit: {housing}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvDisp.DataSource = bs; // refresh grid
                SetAddMode();    // back to normal mode
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAddMode();
            dgvDisp.ClearSelection();
        }
    }
}
