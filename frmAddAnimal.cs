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
        public frmAddAnimal()
        {
            InitializeComponent();
        }

        private void frmAddAnimal_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            DataHandler dth = new DataHandler();

            //1. Read and trim the text boxes
            string AnimalID = (txtAnimalID.Text).Trim().ToUpper();
            string Name = txtName.Text.Trim();
            string Species = txtSpecies.Text.Trim();
            string Age = txtAge.Text.Trim();
            string RecoveryScore = txtScore.Text.Trim();

            //2. Do the validation
            //ensure the animal id is in the following format WR-0000
            if (AnimalID.Length == 7 && AnimalID.StartsWith("WR-") && int.TryParse(AnimalID.Substring(3), out int code))
            {
                var (animals, skipped) = dth.LoadAnimals();
                foreach (Animal a in animals)
                {
                    if (AnimalID == a.AnimalID)
                    {
                        MessageBox.Show($"{AnimalID} already exists in the animal file", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAnimalID.Focus();
                        return;
                    }
                }
            }

            //ensure the name ans species have 30 characters and no '|'
            if (Name.Contains("|") || Name.Length <= 0 || Name.Length > 30)
            {
                MessageBox.Show("The animal name has to be between 1 to 30 characters long and connot contain '|'",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (Species.Contains("|") || Species.Length <= 0 || Species.Length > 30)
            {
                MessageBox.Show("The species has to be between 1 to 30 characters long and connot contain '|'",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecies.Focus();
                return;
            }

            //ensure the age and recovery score is actually numbers
            if (!int.TryParse(Age, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("The age has to be a whole number between 0 and 100",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(RecoveryScore, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("The recovery score has to be a whole number between 0 and 100",
                    "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore.Focus();
                return;
            }


            //3. Set the status and housing unit build object
            

        }
    }
}
