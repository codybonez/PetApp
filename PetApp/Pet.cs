using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public class Pet
    {
    
        
        public string Name { get; set; }


        // Add dateTime for each action [
        // Eating, , Sleeping, and maybe age?
        // Petting requires cooldown and when you reach the limit makes the pet tired
        // ]
        DateTime Time = DateTime.Today;
       
        
        public int Food_Counter { get; set; }
        public int Attention_Counter { get; set; }

        public Status Pet_Status = Status.Happy;
        public Age Pet_Age = Age.Puppy;
        public enum Status
        {
            Happy, 
            Sad,
            Tired,
            Hungry,
            Sleeping
        }
      public enum Age
        {
           Puppy,
           Dog ,
           Elder 
        }
        public DateTime currentTime(Pet pet)
        {
            if (Time.Day <= 7)
            {
                pet.Pet_Age = Age.Puppy;
            }
            else if (Time.Day <= 14)
            {
                pet.Pet_Age = Age.Dog;
            }
            else
            {
                pet.Pet_Age= Age.Elder;
            }
        
            return Time;
        }
    public void petDog(Pet pet  )
    {
            // GOAL: Add cooldown every 30 minutes to give pet attention
        
            if (pet.Pet_Age == Pet.Age.Puppy)
            {
                if (pet.Attention_Counter > 7 )
                {
                   
                    MessageBox.Show($"{pet.Name} is tired. Please wait until {pet.Name} wants attention");

                }
                else
                {
                    MessageBox.Show($"You gave {pet.Name} some pets");
                  
                    pet.Attention_Counter++;
                    
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
            var feedingTime3 = DateTime.Today.AddHours(18.0);
            if (pet.Pet_Age == Pet.Age.Puppy)
            {
                if (pet.Time >= feedingTime1 && pet.Time <= DateTime.Today.AddHours(8))
                {

                }
         
             
            }
            else if (pet.Pet_Age == Pet.Age.Dog)
            {

            }
            else
            {

            }
            return Time;
        }
    }

}
