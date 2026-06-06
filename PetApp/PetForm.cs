using Microsoft.VisualBasic;

namespace PetApp
{
    public partial class PetForm : Form
    {
        public Pet pet = new Pet();


        public PetForm()
        {

            InitializeComponent();
            if (pet.Name == null)
            {
               

                string userInput = Interaction.InputBox("Enter pet name:");
                pet.Name = userInput;
                MessageBox.Show($"Your pet name is {pet.Name}");
            }
            pet.currentTime(pet);
            lblShowTime.Text = pet.currentTime(pet).ToString();
        
            lbl_status.Text = $"Current Status: {pet.Pet_Status}.";
            lbl_petname.Text = $"Pet name: {pet.Name}";
            lbl_PetAge.Text = pet.Pet_Age.ToString();
        }
        
        public void pictureBox1_Click(object sender, EventArgs e)
        {
          
            //if (pet.Pet_Status == Pet.Status.Angry)
            //{
            //    // Save this to csv for status
            //    //PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\AngryDog.jpg";
            //    //string holder = PetPicture.ImageLocation;
            //}
        }
        public void Btn_Feed_Click(object sender, EventArgs e)
        {
            pet.feedDog(pet);

        }

        public void Btn_NamePet_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_PetMe_Click(object sender, EventArgs e)
        {
            pet.petDog(pet);

        

        }

        private void lbl_PetAge_Click(object sender, EventArgs e)
        {

        }
    }
}
