using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PRG282_Project_BaobabRidge
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            var result = handler.LoadAnimals();
            List<Animal> animals = result.Animals;

            int total = animals.Count;
            double avgAge = 0;
            double avgScore = 0;

            int crit = 0, ser = 0, stab = 0, rec = 0, rel = 0;

            //Calculate stats
            if (total > 0)
            {
                avgAge = animals.Average(a => a.Age);
                avgScore = animals.Average(a => a.RecoveryScore);

                foreach (var animal in animals)
                {
                    if (animal.Status == "Critical") crit++;
                    else if (animal.Status == "Serious") ser++;
                    else if (animal.Status == "Stable") stab++;
                    else if (animal.Status == "Recovering") rec++;
                    else if (animal.Status == "Release-Ready") rel++;
                }
            }

            //Display on the form
            label1.Text = $"Total Animals: {total}";
            label2.Text = total > 0 ? $"Average Age: {avgAge.ToString("F2", CultureInfo.InvariantCulture)}" : "Average Age: N/A";
            label3.Text = total > 0 ? $"Average Score: {avgScore.ToString("F2", CultureInfo.InvariantCulture)}" : "Average Score: N/A";
            label4.Text = $"Critical: {crit}";
            label5.Text = $"Serious: {ser}";
            label6.Text = $"Stable: {stab}";
            label7.Text = $"Recovering: {rec}";
            label8.Text = $"Release-Ready: {rel}";

            //Write to summary.txt
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "summary.txt");
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

                string output = "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE\n" +
                                "ANIMAL SUMMARY REPORT\n" +
                                $"Generated: {timestamp}\n\n" +
                                $"Total animals: {total}\n" +
                                $"Average age (years): {(total > 0 ? avgAge.ToString("F2", CultureInfo.InvariantCulture) : "N/A")}\n" +
                                $"Average recovery score: {(total > 0 ? avgScore.ToString("F2", CultureInfo.InvariantCulture) : "N/A")}\n\n" +
                                "Animals per status:\n" +
                                $"Critical: {crit}\n" +
                                $"Serious: {ser}\n" +
                                $"Stable: {stab}\n" +
                                $"Recovering: {rec}\n" +
                                $"Release-Ready: {rel}\n";

                File.WriteAllText(path, output);
                MessageBox.Show("Summary generated and saved to summary.txt!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Cannot write summary.txt. The file might be read-only or you lack permission.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot write summary.txt. The file is in use by another program.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
