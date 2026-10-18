using System.Xml.Linq;

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
            this.Hide();
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
            frmDeleteAnimal delete = new frmDeleteAnimal();
            this.Hide();
            delete.Show();
        }
    }
}
