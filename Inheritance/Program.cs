using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird  = new Bird();
            myBird.Feathers = true;
            myBird.WarmBlooded = true;
            myBird.Diet = "Generalists";
            myBird.BeakLength = 24.5;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myRepitle = new Reptile();
            {
                myRepitle.Scales = true;
                myRepitle.ColdBlooded = true;
                myRepitle.Diet = "carnivore";
                myRepitle.CanGrowTail = true;
            };

            var myAnimals = new Animal[] { myBird, myRepitle };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"extinct: {animal.isExtinct}");
                Console.WriteLine($"is of the {animal.Class} class");
                Console.WriteLine($"beautiful set of {animal.Eyes} eyes");
                Console.WriteLine($"consists of {animal.Legs} legs");
            }


        }
    }
}
