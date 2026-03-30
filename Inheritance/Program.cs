using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            
            Bird parrot =  new Bird()
            {
                Name = "Polly",
                Legs = 2,
                IsAlive = true,
                Age = 2,
                Wings = 2,
                BeakType = "Short stubbed and curved downwards",
                HasFeathers = true,
                IsWarmBlooded = true
            };
            
            Console.WriteLine($"Name: {parrot.Name}\nAmount of Legs:  {parrot.Legs}\nAge:  {parrot.Age}\nAmount of Wings:  {parrot.Wings}\nBeak Type:  {parrot.BeakType}\n");

            if (parrot.IsAlive)
            {
                Console.WriteLine($"{parrot.Name} is Alive!\n");
            }
            
            if (parrot.HasFeathers && parrot.IsWarmBlooded)
            {
                Console.WriteLine($"{parrot.Name} is most definitely a bird!\n");
            }

            if (!parrot.IsAlive)
            {
                Console.WriteLine($"{parrot.Name} is dead!\n");
            }

            if (!parrot.IsWarmBlooded || !parrot.HasFeathers)
            {
                Console.WriteLine($"{parrot.Name} is not a real Parrot!\n");
            }

            if (!parrot.IsAlive && !parrot.IsWarmBlooded && !parrot.HasFeathers)
            {
                Console.WriteLine($"Is there even an animal here?\n");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            Reptiles iguana = new Reptiles()
            {
                Name = "Iggy",
                Legs = 4,
                IsAlive = true,
                Age = 32,
                IsColdBlooded = false,
                HasScales = false,
                SlowMetabolism = false,
                DefenseType = "Drops their tail!"
                
            };
            
            Console.WriteLine("\n===================================================\n");
            
            Console.WriteLine($"Name: {iguana.Name}\nAmount of Legs:  {iguana.Legs}\nAge:  {iguana.Age}\nDefense Type:  {iguana.DefenseType}\n");

            if (iguana.IsAlive)
            {
                Console.WriteLine($"{iguana.Name} is Alive!\n");
            }
            
            if (iguana.HasScales && iguana.IsColdBlooded && iguana.SlowMetabolism)
            {
                Console.WriteLine($"{iguana.Name} is most definitely a reptile!\n");
            }

            if (!iguana.IsAlive)
            {
                Console.WriteLine($"{iguana.Name} is dead!\n");
            }

            if (!iguana.HasScales || !iguana.IsColdBlooded || !iguana.SlowMetabolism)
            {
                Console.WriteLine($"{iguana.Name} is not a real Reptile!\n");
            }

            if (!iguana.IsAlive && !iguana.HasScales && !iguana.IsColdBlooded && !iguana.SlowMetabolism)
            {
                Console.WriteLine($"Is there even an animal here?\n");
            }

        }
    }
}
