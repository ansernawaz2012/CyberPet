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
              

           //  Pet myPet = new Pet(name);

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

            //Dog myDog = new Dog(name);
            /*
            myDog.showState(name);
              
            myDog.eat();
            myDog.play();
            myDog.sleep();
            myDog.showState(name);
            */
            //Console.ReadLine();
        }
    }
}
