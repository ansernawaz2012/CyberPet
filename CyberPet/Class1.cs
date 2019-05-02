using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet
{
    public class Pet
    {
        public Pet(string name)
        {
            PetName = name;
          }
        


        public string PetName { get; set; }

        public int Age { get; set; } = 1;
        public int Hunger { get; set; } = 20;
        public int Boredem { get; set; } = 20;
        public int Fatigue { get; set; } = 20;

        public void eat ()
        {
            if (Hunger> 0)
            {
                Hunger -= 10;
            }
        }

        public void sleep()
        {
            if (Fatigue >= 50)
            {
                Fatigue -= 50;
            
            } else
            {
                Fatigue = 0;
            }
        }

        public void play()
        {
            Boredem -= 10;
        }

        public void rest()
        {
            if (Fatigue >= 20)
            {
                Fatigue -= 20;

            }
            else
            {
                Fatigue = 0;
            }
        }

        public void showState()
        {
            Console.WriteLine($"Pet Name: {PetName}");
            Console.WriteLine($"Pet Hunger: {Hunger}");
            Console.WriteLine($"Pet Boredem: {Boredem}");
            Console.WriteLine($"Pet Fatigue: {Fatigue}");


        }

    }

    




    
}
