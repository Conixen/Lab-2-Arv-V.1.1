using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Arv_V._1._1
{
    public class Cat : Animal    
    {
        public string Claws { get; set; }   // propertys for cat
        // Constructor for cat
        public Cat (string name = "Bondkatt", int age = 3, string location = "Bondgård", string type = "Däggdjur", string consumption = "Carnivore", string claws = "Har klor")
            : base(name, age, location, type, consumption)
        {
            Claws = claws;  // claws property
        }
        public void Climb()     // Method cat
        {
            Console.WriteLine($"{ Name } klättar på saker ");
        }
        public override void MakeSound()    // override makesound method
        {
            Console.WriteLine($"{ Name } jamar: Mjau, mjau" +
                $"\nVill ha sin lyx blöt mat ");
        }
    }
    public class Lion : Cat 
    {
        public string Mane { get; set; }    // property for lion
        // constructor
        public Lion(string name = "Lejon", int age = 6, string location = "Afrika", string type = "Däggdjur", string consumption = "Carnivore", string claws = "Har klor", string mane = "Hannar har en lejonman") 
            : base(name, age, location, type, consumption, claws) 
        {
            Mane = mane;
        }
        public void King()  // method lion
        {
            Console.WriteLine($"{ Name } är djurens konung");
        }

        public override void MakeSound()    // overrode make sound method
        {
            Console.WriteLine($"{Name} ryter: Raawwwrrrr!!!" +
                $"\nVäldigt läskigt jag vet ");
        }
    }
    public class Cheetah : Cat 
    { 
        public string IsFast { get; set; }  // property for cheetah
        // constructor
        public Cheetah(string name = "Geopard", int age = 5, string location = "Afrika", string type = "Däggdjur", string consumption = "Carnivore", string claws = "Har klor", string isFast = "Är det snabbaste landdjuret")
           : base(name, age, location, type, consumption, claws)
        {
            IsFast = isFast;
        }
        public void Daytime() // method for cheetah
        {
            Console.WriteLine($"{ Name } jagar på dagen");
        }
        public override void MakeSound()    // ovverride makesound method
        {
            Console.WriteLine($"{ Name } kvittrar: Chirp Chirp" +
                $"\nBlev förrvirad själv när jag läste detta...");
        }
    }
}
