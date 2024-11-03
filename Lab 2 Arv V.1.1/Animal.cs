using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2_Arv_V._1._1
{
    public class Animal
    {
        public string Name { get; set; }    // Name of the animal
        public int Age { get; set; }    // Age of the animal
        public string Location { get; set; }    // Location of animal
        public string Type { get; set; }    // Mammal, reptile, bird
        public string Consumption { get; set; } // Carnivore, herbivore

        // Konstruktor
        public Animal(string name, int age, string location, string type, string consumption) 
        {
            Name = name;
            Age = age;
            Location = location;
            Type = type;
            Consumption = consumption;
        }
        // Methods that all animals have
        public virtual void Sleep()
        {
            Console.WriteLine($"{ Name } sover");
        }
        public virtual void Breathe() 
        {
            Console.WriteLine($"{ Name } andas");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} låter");
        }
    }
}
