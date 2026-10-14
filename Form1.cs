namespace PRG282_Project_BaobabRidge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Setting up the grid programmatically to display all the animal records
            DataGridView dgvAnimals = new DataGridView();
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.Location = new System.Drawing.Point(12, 100);
            dgvAnimals.Size = new System.Drawing.Size(760, 330);
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvAnimals);

            // Calling our DataHandler to read and validate the text file data
            DataHandler handler = new DataHandler();
            var result = handler.LoadAnimals();

            // Binding the loaded animal list straight into the grid view
            dgvAnimals.DataSource = result.Animals;
        }

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            // Event hooked up to the "Add Animal" button from the designer
            MessageBox.Show("Add Animal navigation placeholder");
        }
    }
}
        

    
