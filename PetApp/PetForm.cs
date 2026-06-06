using Microsoft.VisualBasic;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        public void petDog(Pet pet)
        {
            // GOAL: Add cooldown every 30 minutes to give pet attention
            pet.Time = DateTime.Now;
            var cooldown = pet.Time.AddMinutes(30.0);
            if (pet.Pet_Age == Pet.Age.Puppy)
            {
                if (pet.Time == cooldown && pet.Pet_Status != Pet.Status.Sleeping)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");


                }
                else
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");


                }
            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {

                if (pet.Attention_Counter > 5)
                {

                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");

                }
                else
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    pet.Attention_Counter++;
                }
            }
            else
            {

                if (pet.Attention_Counter > 3)
                {

                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");

                }
                else
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    pet.Attention_Counter++;
                }
            }

        }
        public DateTime feedDog(Pet pet)
        {
            pet.Time = DateTime.Now;
            var feedingTime1 = DateTime.Today.AddHours(7.0);
            var feedingTime2 = DateTime.Today.AddHours(12.0);
            var feedingTime3 = DateTime.Today.AddHours(16.0);
            var feedingTime4 = DateTime.Today.AddHours(19.0);
            if (pet.Pet_Age == Pet.Age.Puppy)
            {


                if (
                       pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8) 
                    || pet.Time >= feedingTime2 && pet.Time <= DateTime.Today.AddHours(13)
                    || pet.Time >= feedingTime3 && pet.Time <= DateTime.Today.AddHours(17)
                    || pet.Time >= feedingTime4 && pet.Time <= DateTime.Today.AddHours(20)

                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");
                    lbl_status.Text = $"Current Status: {Pet.Status.Happy.ToString()}";

                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HappyDog.png";

                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");
                    lbl_status.Text = $"Current Status: {Pet.Status.Hungry.ToString()}";
                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HungryDog.png";
                }


            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {
                feedingTime3 = DateTime.Today.AddHours(18);

                if (
                       pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8)
                    || pet.Time >= feedingTime2 && pet.Time <= DateTime.Today.AddHours(13)
                    || pet.Time >= feedingTime3 && pet.Time <= DateTime.Today.AddHours(19)
                

                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");
                    lbl_status.Text = $"Current Status: {Pet.Status.Happy.ToString()}";

                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HappyDog.png";

                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");
                    lbl_status.Text = $"Current Status: {Pet.Status.Hungry.ToString()}";
                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HungryDog.png";
                }
            }
            else
            {
                feedingTime3 = DateTime.Today.AddHours(18);
                if (
                       pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8)
                   
                    || pet.Time >= feedingTime3 && pet.Time <= DateTime.Today.AddHours(19)


                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");
                    lbl_status.Text = $"Current Status: {Pet.Status.Happy.ToString()}";

                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HappyDog.png";

                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");
                    lbl_status.Text = $"Current Status: {Pet.Status.Hungry.ToString()}";
                    PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\HungryDog.png";
                }
            }
            return pet.Time;
        }


        public void pictureBox1_Click(object sender, EventArgs e)
        {

            
                // Save this to csv for status

                PetPicture.ImageLocation = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\Photos\\AngryDog.jpg";
                string holder = PetPicture.ImageLocation;
            
        }
        public void Btn_Feed_Click(object sender, EventArgs e)
        {
           feedDog(pet);

        }

        public void Btn_NamePet_Click(object sender, EventArgs e)
        {


        }



        private void Btn_PetMe_Click(object sender, EventArgs e)
        {
          petDog(pet);



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
