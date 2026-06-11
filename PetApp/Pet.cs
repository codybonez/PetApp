using PetApp.Properties;
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

        public bool Is_Fed;
        public int Food_Counter { get; set; }
        public int Attention_Counter { get; set; }
        public int Days_Old { get; set; }
        public Status Pet_Status { get; set; }
        public Age Pet_Age {get; set;}

        public string Pet_Image { get; set; }
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
          Old_Fella
        }
        public Pet currentTime(Pet pet)
        {
            if (pet.Days_Old == 7)
            {
                pet.Pet_Age = Age.Puppy;
            }
            else if (pet.Days_Old == 14)
            {
                pet.Pet_Age = Age.Dog;
            }
            else if (pet.Days_Old == 30)
            {
                pet.Pet_Age= Age.Old_Fella;
            }
        
            return pet;
        }

       public void Save()
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText("PetStatus.json", jsonString);

        }
        public  Pet Load(Pet pet)
        {
            string jsonFromFile;
            string filepath = "C:\\Users\\CodyB\\source\\repos\\PetApp\\PetApp\\bin\\Debug\\net9.0-windows\\PetStatus.Json";
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
                pet.Days_Old = loadedProducts.Days_Old;
                pet.Pet_Image = loadedProducts.Pet_Image;
                
                return loadedProducts;
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Could not load data");
            }
            return pet;
           

        }
        public void DayReset(Pet pet)
        {
          
                pet.Attention_Counter = 0;
                pet.Days_Old++;
                pet.Food_Counter = 0;
                pet.Time = DateTime.Now;
                pet.Save();
            
        }
    
    }

}
