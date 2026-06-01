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
        public int Bowls_Eaten { get; set; }
        public string Puppy { get; set; }
        public string Dog { get; set; }
        public string Elder { get; set; }

        public Status Pet_Status = Status.Happy;
        public enum Status
        {
            Happy, 
            Sad,
            Tired,
            Hungry,
            Angry,
            Sleeping
        }
      
        public void PetDog(Pet pet)
        {



        }

    }
}
