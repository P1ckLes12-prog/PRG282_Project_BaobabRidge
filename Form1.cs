namespace PRG282_Project_BaobabRidge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            frmAddAnimal addAnimal = new frmAddAnimal();
            addAnimal.Show();
        }
    }
}
