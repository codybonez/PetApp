using Microsoft.VisualBasic;
using PetApp.Properties;
using System.Timers;
using static PetApp.Pet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PetApp
{
    public partial class PetForm : Form
    {
        public Pet pet = new Pet();
        System.Timers.Timer lastFedTimer;
        private System.Windows.Forms.Timer timer;
        public PetForm()
        {

             pet.Load(pet);
            InitializeComponent();
            InitializeDateTimeTracker();
            if (pet.Name == null)
            {


                string userInput = Interaction.InputBox("Enter your new pet name. Choose wisely:");
                pet.Name = userInput;
                MessageBox.Show($"Your pet name is {pet.Name}");

            }



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
                CheckForStatus(pet, pet.Time);
                lbl_status.Text = $"Current Status: {pet.Pet_Status}";



            };

            // Start the timer
            timer.Start();

        }
        public void petDog(Pet pet)
        {

            pet.Time = DateTime.Now;
            if (pet.Time >= DateTime.Today.AddHours(24))
            {
                pet.Attention_Counter = 0;
            }

            if (pet.Pet_Age == Pet.Age.Puppy)
            {
                if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter <= 10)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    PetPicture.ImageLocation = Properties.Resources.HappyDog.ToString();
                    pet.Attention_Counter++;


                    pet.Pet_Status = Pet.Status.Happy;


                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter >= 10)
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until the day ends");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired;
                }
                else
                {

                }




            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {


                if (pet.Pet_Status != Pet.Status.Sleeping)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");


                }
                else
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");


                }
            }
            else
            {


                if (pet.Pet_Status != Pet.Status.Sleeping)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");


                }
                else
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");


                }
            }

        }
        public DateTime feedDog(Pet pet)
        {
          if (lastFedTimer.Enabled)
            {
                lastFedTimer.Stop();
            }
            var feedingTime1 = DateTime.Today.AddHours(7.0);
            var feedingTime2 = DateTime.Today.AddHours(12.0);
            var feedingTime3 = DateTime.Today.AddHours(16.0);
            var feedingTime4 = DateTime.Today.AddHours(19.0);
            
            pet.Time = DateTime.Now;
            if (pet.Pet_Age == Pet.Age.Puppy)
            {


                if (
                       pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8) && pet.Pet_Status == Pet.Status.Hungry
                    || pet.Time >= feedingTime2 && pet.Time <= DateTime.Today.AddHours(12).AddMinutes(8) && pet.Pet_Status == Pet.Status.Hungry
                    || pet.Time >= feedingTime3 && pet.Time <= DateTime.Today.AddHours(17) && pet.Pet_Status == Pet.Status.Hungry
                    || pet.Time >= feedingTime4 && pet.Time <= DateTime.Today.AddHours(20) && pet.Pet_Status == Pet.Status.Hungry

                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");
                
                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";

                    PetPicture.ImageLocation = PetPicture.ImageLocation = Resources.HappyDog.ToString();

                }
                else
                {
                    // change so that the pet becomes hungry at the given time
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");

                }


            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {
                feedingTime3 = DateTime.Today.AddHours(18);

                if ( pet.Pet_Status == Pet.Status.Hungry ) 
                {
                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";

                    PetPicture.ImageLocation = PetPicture.ImageLocation = Resources.HappyDog.ToString();
                    
                    lastFedTimer = new System.Timers.Timer
                    {
                        Interval = 18000
                    };
                    lastFedTimer.Elapsed += (sender, e) =>
                    {
                        pet.Pet_Status = Status.Hungry;
                    };
                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");
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
                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";

                    PetPicture.ImageLocation = PetPicture.ImageLocation = Resources.HappyDog.ToString();

                    lastFedTimer = new System.Timers.Timer
                    {
                        Interval = 18000
                    };
                    lastFedTimer.Elapsed += (sender, e) =>
                    {
                        pet.Pet_Status = Status.Hungry;
                    };

                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");

                }
            }
            return pet.Time;
        }


        public void pictureBox1_Click(object sender, EventArgs e)
        {


            // Save this to csv for status

            PetPicture.ImageLocation = Resources.AngryDog.ToString();
            string holder = PetPicture.ImageLocation;

        }
        public void Btn_Feed_Click(object sender, EventArgs e)
        {

            feedDog(pet);
          
            
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

        public void CheckForStatus(Pet pet, DateTime _time)
        {
            _time = DateTime.Now;

            var feedingTime1 = DateTime.Today.AddHours(7.0);
            var feedingTime2 = DateTime.Today.AddHours(12.0).AddMinutes(11);
            var feedingTimePup3 = DateTime.Today.AddHours(16.0);
            var feedingTime3 = DateTime.Today.AddHours(19.0);
            var sleepTime = DateTime.Today.AddHours(21.5);
            var wakeupTime = DateTime.Today.AddHours(6.5);


            if (pet.Pet_Age == Age.Puppy)
            {

                if (_time == feedingTime1 || _time == feedingTime2 || _time == feedingTimePup3 || _time == feedingTime3 )
                {
                    pet.Pet_Status = Pet.Status.Hungry;

                    PetPicture.ImageLocation = Properties.Resources.HungryDog.ToString();

                }
            }
            else if (pet.Pet_Age == Age.Dog)
            {
                if (_time == feedingTime1 || _time >= feedingTime2 || _time == feedingTime3)
                {

                    pet.Pet_Status = Pet.Status.Hungry;
                    PetPicture.ImageLocation = Resources.HungryDog.ToString();

                }
            }
            else
            {
                if (_time == feedingTime1 || _time == feedingTime3)
                {
                    pet.Pet_Status = Pet.Status.Hungry;
                    PetPicture.ImageLocation = Properties.Resources.HungryDog.ToString();
                }


            }
            //if (pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8)) { }

            // Check for feeding times

            if (_time >= sleepTime)
            {
                pet.Pet_Status = Pet.Status.Sleeping;
                PetPicture.ImageLocation = Resources.SleepyDog.ToString();
            }
            else if (_time >= wakeupTime && _time < feedingTime1)
            {
                pet.Pet_Status = Pet.Status.Tired;
                PetPicture.ImageLocation = PetPicture.ImageLocation = Resources.TiredDog.ToString();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            pet.Save();
        }

     
    }
}
