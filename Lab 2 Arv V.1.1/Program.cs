namespace Lab_2_Arv_V._1._1
{
    internal class Program
    {                                                               // Leon Johansson SUT24
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\nOcH välkommen till zoo;et");
            Console.WriteLine("Nu börjar vi presentera alla djur");
            
            // Creating the the animal types
            Cat garfield = new Cat();
            Lion scar = new Lion();
            Cheetah sasha = new Cheetah();
            Platypus perry = new Platypus();
            Penguin oswald = new Penguin();

            //List of animals in zoo and adding all animal types
            List<Animal> zoo = new List<Animal> { garfield, scar, sasha, perry, oswald};

            // Iterate each animal in the zoo list
            foreach (Animal animal in zoo) 
            {   // Properties that they all have
                Console.WriteLine($"Namn: {animal.Name}");
                Console.WriteLine($"Ålder: {animal.Age}");
                Console.WriteLine($"Plats: {animal.Location}");
                Console.WriteLine($"Typ: {animal.Type}");
                Console.WriteLine($"Kost: {animal.Consumption}");
                Console.WriteLine("");

                // Meth that they all have
                animal.Sleep();
                animal.Breathe();
                animal.MakeSound();

                // Checks which animal it is and the coresponding properties and methodes
                Console.WriteLine("");
                if (animal is Cat cat)
                {
                    cat.Climb();
                }
                if (animal is Lion lion)    
                {
                    lion.King();
                }
                if (animal is Cheetah cheetah)
                {
                    cheetah.Daytime();
                }
                else if (animal is Platypus platypus) 
                {
                    platypus.LayEgg();
                }
                else if (animal is Penguin penguin) 
                {
                    penguin.Flightless();
                }
                Console.WriteLine("Press any button to countine...");
                Console.ReadKey();
                Console.WriteLine("\n----------------------\n");
            }
            Console.WriteLine("Det var alla djur vi har med oss för idag, ha en bra dag!");
        }
    }
}
