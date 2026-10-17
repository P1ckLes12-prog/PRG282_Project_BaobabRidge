namespace PRG282_Project_BaobabRidge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataHandler handler = new DataHandler();
            var result = handler.LoadAnimals();
            dgvAnimals.DataSource = result.Animals;
        }

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            frmAddAnimal addAnimal = new frmAddAnimal();
            addAnimal.Show();
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUpdateAnimal().Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataHandler dth = new DataHandler();

            if(dgvAnimals.CurrentRow == null)
            {
                MessageBox.Show("Please select a row first", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = dgvAnimals.CurrentRow.Cells[0].Value?.ToString();

            if(string.IsNullOrEmpty(id) )
            {
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete animal with id {id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                dth.DeleteAnimal(id);
                List<Animal> animals = dth.LoadAnimals().Animals;
                BindingSource binding = new BindingSource();
                binding.DataSource = animals;
                dgvAnimals.DataSource = binding;
            }
        }
    }
}
