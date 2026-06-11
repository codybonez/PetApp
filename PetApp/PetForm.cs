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
      System.Windows.Forms.Timer lastFedTimer = new System.Windows.Forms.Timer();   
        
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public PetForm()
        {

            pet.Load(pet);
            InitializeComponent();
            InitializeDateTimeTracker();
            if (pet.Food_Counter == 0 && pet.Pet_Status != Status.Sleeping)
            {
                pet.Pet_Status = Status.Hungry;
                PetPicture.ImageLocation = Properties.Resources.HungryDog.ToString();
            }
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
           
            if (pet.Pet_Age == Pet.Age.Puppy)
            {
                if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter <= 10)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    PetPicture.ImageLocation = Properties.Resources.HappyDog.ToString();
                    pet.Attention_Counter++;


                    pet.Pet_Status = Pet.Status.Happy;
                    pet.Save();

                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter >= 10)
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until the day ends");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired; pet.Save();
                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter < 5 && pet.Time >= DateTime.Today.AddHours(17) && pet.Food_Counter < 2)
                {
                    MessageBox.Show($"{pet.Name} is sad, please give some love");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired; pet.Save();
                }




            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {


                if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter <= 10)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    PetPicture.ImageLocation = Properties.Resources.HappyDog.ToString();
                    pet.Attention_Counter++;


                    pet.Pet_Status = Pet.Status.Happy;
                    pet.Save();

                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter >= 10)
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until the day ends");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired; pet.Save();
                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter < 4 && pet.Time >= DateTime.Today.AddHours(17) && pet.Food_Counter < 2)
                {
                    MessageBox.Show($"{pet.Name} is sad, please give some love");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired; pet.Save();
                }
            }
            else
            {


                if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter <= 10)
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                    PetPicture.ImageLocation = Properties.Resources.HappyDog.ToString();
                    pet.Attention_Counter++;


                    pet.Pet_Status = Pet.Status.Happy;
                    pet.Save();

                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter >= 10)
                {
                    MessageBox.Show($"{pet.Name} is tired. Please wait until the day ends");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired;
                    pet.Save();
                }
                else if (pet.Pet_Status != Pet.Status.Sleeping && pet.Attention_Counter < 3 && pet.Time >= DateTime.Today.AddHours(17) && pet.Food_Counter < 2)
                {
                    MessageBox.Show($"{pet.Name} is sad, please give some love");
                    PetPicture.ImageLocation = Properties.Resources.TiredDog.ToString();
                    pet.Pet_Status = Pet.Status.Tired; pet.Save();
                }
            }

        }


        // Create reset day function that resets food counter

        public DateTime feedDog(Pet pet)
        {

         
            

            
            
          if (lastFedTimer.Enabled)
            {
                lastFedTimer.Stop();
                MessageBox.Show("");
            }
          
            pet.Time = DateTime.Now;
            if (pet.Pet_Age == Pet.Age.Puppy)
            {


                if (
                        pet.Pet_Status == Pet.Status.Hungry && pet.Is_Fed == false && pet.Food_Counter <= 4
                 

                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");

                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";
                    pet.Food_Counter++;
                    PetPicture.ImageLocation = Resources.HappyDog.ToString();
                    pet.Is_Fed = true;
                    pet.Save();
                    lastFedTimer = new System.Windows.Forms.Timer
                    {
                        Interval = 10800000
                     
                    };
                    lastFedTimer.Tick += (sender, e) =>
                    {
                        if (pet.Pet_Status == Status.Sleeping || pet.Pet_Status == Status.Tired)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show($"Please feed {pet.Name}");
                            pet.Pet_Status = Status.Hungry;
                            PetPicture.ImageLocation = Resources.HungryDog.ToString();
                            pet.Is_Fed = false;
                            lastFedTimer.Dispose();
                            pet.Save();
                        }
                    

                    };
                    lastFedTimer.Start();
                }
                else
                {
                    // change so that the pet becomes hungry at the given time
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");

                }


            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {
                

                if ( pet.Pet_Status == Pet.Status.Hungry && pet.Is_Fed == false && pet.Food_Counter <= 3) 
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");

                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";
                    pet.Food_Counter++;
                    PetPicture.ImageLocation = Resources.HappyDog.ToString();
                    pet.Is_Fed = true;
                    pet.Save();
                    lastFedTimer = new System.Windows.Forms.Timer
                    {
                        Interval = 14400000

                    };
                  
                    lastFedTimer.Tick += (sender, e) =>
                    {
                        MessageBox.Show($"Please feed {pet.Name}");
                        pet.Pet_Status = Status.Hungry;
                        PetPicture.ImageLocation = Resources.HungryDog.ToString();
                        pet.Is_Fed = false;
                        lastFedTimer.Dispose();
                        pet.Save();
                    };
                    lastFedTimer.Start();

                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food or you missed the feeding time. Please wait unitl the correct time");
                }
            }
            else
            {

                if (


                   pet.Is_Fed == false && pet.Pet_Status == Status.Hungry && pet.Food_Counter <= 2


                    )
                {
                    MessageBox.Show($"{pet.Name} is now well fed.");

                    pet.Pet_Status = Pet.Status.Happy;
                    lbl_status.Text = $"Current Status: {pet.Pet_Status.ToString()}";
                    pet.Food_Counter++;
                    PetPicture.ImageLocation = Resources.HappyDog.ToString();
                    pet.Is_Fed = true;
                    pet.Save();
                    lastFedTimer = new System.Windows.Forms.Timer
                    {
                        Interval =18000000
                        
                    };
                    lastFedTimer.Tick += (sender, e) =>
                    {
                        MessageBox.Show($"Please feed {pet.Name}");
                        pet.Pet_Status = Status.Hungry;
                        PetPicture.ImageLocation = Resources.HungryDog.ToString();
                        pet.Is_Fed = false;
                        lastFedTimer.Dispose();
                        pet.Save();

                    };
                    lastFedTimer.Start();


                }
                else
                {
                    MessageBox.Show($"{pet.Name} does not need food. Please wait unitl the correct time");

                }
            }
            return pet.Time;
        }


        public void pictureBox1_Click(object sender, EventArgs e)
        {


            // Save this to csv for status

            PetPicture.ImageLocation = Resources.AngryDog.ToString();
           

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
            MessageBox.Show("\nPuppies: Every 3 hours up to 4 times per day\n"
                 +
                "\nAdults: Every 4 hours up to 3 times per day\n"
                + "\nOld Fellers: Every 5 hours up to 2 times per day\n"

                );
        }

        public void CheckForStatus(Pet pet, DateTime _time)
        {
            _time = DateTime.Now;

         
            var sleepTime = DateTime.Today.AddHours(21.5);
            var wakeupTime = DateTime.Today.AddHours(6.5);


            

            // Check for feeding times

            if (_time >= sleepTime && _time < DateTime.Today.AddHours(8))
            {
                pet.Pet_Status = Pet.Status.Sleeping;
                PetPicture.ImageLocation = Resources.SleepyDog.ToString();
                pet.DayReset(pet);
                pet.Save();
            }
       
          

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            pet.Save();
        }

     
    }
}
