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
            DogName = name;
            playWithPet();
                }

        public string DogName { get; }
        public Boolean canBark = true;

        public void playFetch()
        {
            Fatigue += 10;
        }

        


    }

    
}
