using Microsoft.VisualBasic;

namespace PetApp
{
    public partial class PetForm : Form
    {
        public Pet pet = new Pet();
        public PetForm()
        {
            InitializeComponent();

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Btn_Feed_Click(object sender, EventArgs e)
        {


        }

        public void Btn_NamePet_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Enter pet name:");
            pet.Name = userInput;
            MessageBox.Show($"Your pet name is {pet.Name}");

        }
    }
}
