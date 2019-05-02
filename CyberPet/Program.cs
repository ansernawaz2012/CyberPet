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
            Pet myPet = new Pet("Roger");

            myPet.showState();

            myPet.eat();
            myPet.play();
            myPet.sleep();
            myPet.showState();
            Console.ReadLine();
        }
    }
}
