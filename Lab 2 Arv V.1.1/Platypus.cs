using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2_Arv_V._1._1
{
    public class Platypus : Animal
    {
        private string Venomous;    // property platypus
        // constructor
        public Platypus(string name = "Näbbdjur", int age = 2, string location = "Australien", string type = "Kloakdjur/Däggdjur", string consumption = "Carnivore",  string venomous = "Giftig")
            : base(name, age, location, type, consumption) 
        {
            Venomous = venomous;
        }

        public void LayEgg()    // method platypus
        {
            Console.WriteLine($"{ Name } lägger ägg, ett av de få däggdjur som inte föder levande ungar");
        }
        public override void MakeSound()    // override for make sound method
        {
            Console.WriteLine($"{ Name } låter så här: Grwol growl" +
                $"\nDe är väldigt tysta djur men kan låta mycket under parningstiden.");
        }
    }
}
