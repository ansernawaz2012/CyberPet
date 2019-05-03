using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyberPet
{
     class Dog : Pet 
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine($"A pet dog named {name} has been created");
                }


        public Boolean canBark = true;

        public void playFetch()
        {
            Fatigue += 10;
        }

        public void playWithDog()
        {
            while(isAlive)
            {
                showState();
                Console.WriteLine("What would you like to do?");

            }
        }


    }

    
}
