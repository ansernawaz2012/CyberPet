using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose your new pet: C for cat, D for dog and R for rabbit");
            string petType = Console.ReadLine();
              Console.WriteLine("Enter the name of your pet:");
              string name = Console.ReadLine();
              

           //User defines type of pet to be created
            switch(petType)
            {
                case "c": Cat myCat = new Cat(name);
                    break;
                case "d":
                    Dog myDog = new Dog(name);
                    break;
                case "r":
                    Rabbit myRabbit = new Rabbit(name);
                    break;
                default:
                    break;

            }

            
            Console.ReadLine();
        }
    }
}
