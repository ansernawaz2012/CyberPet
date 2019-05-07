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

        

        public void petHunger(int amount)
        {
            Hunger += amount;
            if (Hunger < 0)
            {
                Hunger = 0;
            }
            //else if(Hunger >= 90)
            //{
                
            //}
        }

        public void petFatigue(int amount)
        {
            Fatigue += amount;
            if (Fatigue < 0)
            {
                Fatigue = 0;
            }
            //else if(Fatigue >= 90)
            //{

            //}
        }

        public void petBoredem(int amount)
        {
            Boredem += amount;
            if (Boredem < 0)
            {
                Boredem = 0;
            }
            //else if(Boredem >= 90)
            //{

            //}
        }

        public void eat()
        {
            petHunger(-50);

        }

        public void sleep()
        {
            petFatigue(-50);

            petHunger(20);
        }

        public void play()
        {
            petBoredem(-25);
            petFatigue(10);

            petHunger(15);
        }

        public void rest()
        {
            petFatigue(-20);
            petHunger(5);
        }

        public void ignorePet()
        {
            petFatigue(10);
            petBoredem(10);
            petHunger(10);
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
