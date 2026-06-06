using Microsoft.VisualBasic;
using System.Timers;

namespace PetApp
{
    public partial class PetForm : Form
    {
        public Pet pet = new Pet();

        private System.Windows.Forms.Timer timer;
        public PetForm()
        {


            InitializeComponent();
            InitializeDateTimeTracker();
            if (pet.Name == null)
            {


                string userInput = Interaction.InputBox("Enter pet name:");
                pet.Name = userInput;
                MessageBox.Show($"Your pet name is {pet.Name}");
            }


            lbl_status.Text = $"Current Status: {pet.Pet_Status}";
            lbl_petname.Text = $"Pet Name: {pet.Name}";
            lbl_PetAge.Text = $" Pet Age: {pet.Pet_Age.ToString()}";
        }

        public void InitializeDateTimeTracker()
        {

            this.Controls.Add(lblShowTime);

            // Create and configure the timer
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1 second

            };

            timer.Tick += (sender, e) =>
            {
                lblShowTime.Text = DateTime.Now.ToString("F");
                pet.currentTime(pet);


            };

            // Start the timer
            timer.Start();

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



        private void Btn_PetMe_Click(object sender, EventArgs e)
        {
            pet.petDog(pet);



        }

        private void lbl_PetAge_Click(object sender, EventArgs e)
        {

        }

        private void PetForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_petCooldown_Click(object sender, EventArgs e)
        {

        }

        private void btn_FeedingTimes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nPuppies:" +
                "\nMeal 1: Between 7:00 and 8:00 AM\nMeal 2: Between 12:00 and 1:00 PM\nMeal 3: Between 4:00 and 5:00PM\nMeal 4: Between 7:00 and 8:00PM\n" +
                "\nAdults: \nMeal 1: Between 7:00 and 8:00 AM\nMeal 2: Between 12:00 and 1:00 PM\nMeal 3: Between 6:00 and 7:00\n"
                + "\nOld Fellers: \nMeal 1: Between 7:00 and 8:00 AM\nMeal 2: Between 6:00 and 7:00 PM"

                );
        }
    }
}
