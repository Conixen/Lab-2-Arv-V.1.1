using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2_Arv_V._1._1
{
    public class Penguin : Animal
    {
        public string Swims { get; set; }   // property penguin
        // constructor
        public Penguin(string name = "Pingvin", int age = 8, string location = "Antarkis", string type = "Fågel", string consumption = "Carnivore", string swims = "Simmar")
            : base(name, age, location, type, consumption)
        {
            Swims = swims;
        }
        public void Flightless() // method peguin
        {
            Console.WriteLine($"{ Name } kan inte flyga :(");
        }
        public override void MakeSound()    //override make sound method
        {
            Console.WriteLine($"{ Name } låter så här: Honk honk eller Brr brr" +
                $"\nLite som en gnällig trumpet");
        }
    }
}
