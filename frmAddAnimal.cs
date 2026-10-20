using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmAddAnimal : Form
    {
        DataHandler dth = new DataHandler();
        public frmAddAnimal()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            //1. Read and trim the text boxes
            string AnimalID = (txtAnimalID.Text).Trim().ToUpper();
            string Name = txtName.Text.Trim();
            string Species = txtSpecies.Text.Trim();
            string AgeText = txtAge.Text.Trim();
            string RecoveryScoreText = txtScore.Text.Trim();

            //2. Do the validation
            //ensure the animal id is in the following format WR-0000
            if (!Animal.IsValidID(AnimalID))
            {
                MessageBox.Show($"{AnimalID} must be 'WR-' followed by exactly 4 digits.", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnimalID.Focus();
                return;
            }

            //ensure the name ans species have 30 characters and no '|'
            if (Name.Contains("|") || Name.Length <= 0 || Name.Length > 30)
            {
                MessageBox.Show("The animal name has to be between 1 to 30 characters long and cannot contain '|'",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (Species.Contains("|") || Species.Length <= 0 || Species.Length > 30)
            {
                MessageBox.Show("The species has to be between 1 to 30 characters long and cannot contain '|'",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecies.Focus();
                return;
            }

            //ensure the age and recovery score is actually numbers
            if (!int.TryParse(AgeText, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("The age has to be a whole number between 0 and 100",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(RecoveryScoreText, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("The recovery score has to be a whole number between 0 and 100",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore.Focus();
                return;
            }

            //3. Set the status and housing unit build object
            var (status, housingUnit) = Animal.ClassifyRecoveryScore(score);

            Animal animal = new Animal
            {
                AnimalID = AnimalID,
                Name = Name,
                Species = Species,
                Age = age,
                RecoveryScore = score,
                Status = status,
                HousingUnit = housingUnit
            };

            //4. Error handling
            try
            {
                //check if the ID already exists in the file
                if (dth.IdExists(AnimalID))
                {
                    MessageBox.Show($"{AnimalID} already exists in the animal file", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnimalID.Focus();
                    return;
                }

                dth.AddAnimal(animal);

                MessageBox.Show($"Saved. Status: {status}, Housing unit: {housingUnit}");

                //clear the text boxes
                txtAnimalID.Clear();
                txtName.Clear();
                txtSpecies.Clear();
                txtAge.Clear();
                txtScore.Clear();

                //clear the grid when view is added
                //==============================================================================================================================================
                //==============================================================================================================================================

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"The file is read-only or you lack permissions", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show($"The file is in use by another program", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
