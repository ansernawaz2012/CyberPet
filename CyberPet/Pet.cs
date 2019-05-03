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
        public Boolean petIsAlive = true;
        public Boolean endGame = false;

        public void eat ()
        {
            if (Hunger >=  50)
            {
                Hunger -= 50;
            } else
            {
                Hunger = 0;
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
            if(Boredem>= 10)
            {
                Boredem -= 10;
            } else
            {
                Boredem = 0;
            }
            Fatigue += 10;
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

        public void ignorePet()
        {
            Hunger += 10;
            Boredem += 10;
            Fatigue += 5;
        }

        public void showState(string name)
        {
            Console.WriteLine($"Pet Name: {name}");
            Console.WriteLine($"Pet Hunger: {Hunger}");
            Console.WriteLine($"Pet Boredem: {Boredem}");
            Console.WriteLine($"Pet Fatigue: {Fatigue}");


        }

        public void playWithPet()
        {
            while (petIsAlive && !endGame)
            {
                showState(PetName);
                Console.WriteLine($"What would you {PetName} like to do?");
                Console.WriteLine("p to play, e to eat, s to sleep, r to rest, i to ignore, q to quit");
                string OwnerInstruction = Console.ReadLine();

                switch (OwnerInstruction)
                {
                    case "p":
                        play();
                        break;
                    case "e":
                        eat();
                        break;
                    case "s":
                        sleep();
                        break;
                    case "r":
                        rest();
                        break;
                    case "i":
                        ignorePet();
                        break;
                    case "q":
                        endGame = true;
                        break;
                    default:
                        break;

                }
            }
        }

    }

    




    
}
