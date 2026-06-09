using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetApp
{
    public class Pet
    {

        // add save method (save with json serializer)
        // add load button (load it from json)
        public string Name { get; set; }


        // Add dateTime for each action [
        // Eating, , Sleeping, and maybe age?
        // Petting requires cooldown and when you reach the limit makes the pet tired
        // ]
        public DateTime Time = DateTime.Today;


        public int Food_Counter { get; set; }
        public int Attention_Counter { get; set; }

        public Status Pet_Status { get; set; }
        public Age Pet_Age {get; set;}
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

       public void Save()
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText("PetStatus.json", jsonString);

        }
        public  Pet Load(Pet pet)
        {
            string jsonFromFile;
            string filepath = "C:\\Users\\codynorwood\\source\\repos\\PetApp\\PetApp\\bin\\Debug\\net9.0-windows\\PetStatus.Json";
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File does not exist");

            }
            try
            {
                jsonFromFile = File.ReadAllText("PetStatus.json");

                var loadedProducts = JsonSerializer.Deserialize<Pet>(jsonFromFile);
                pet.Name = loadedProducts.Name;
                pet.Pet_Status = loadedProducts.Pet_Status;
                pet.Attention_Counter = loadedProducts.Attention_Counter;
                pet.Food_Counter = loadedProducts.Food_Counter;
                return loadedProducts;
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Could not load data");
            }
            return pet;
           

        }
    
    }

}
