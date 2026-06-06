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
         public DateTime Time = DateTime.Today;
       
        
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
    
    }

}
