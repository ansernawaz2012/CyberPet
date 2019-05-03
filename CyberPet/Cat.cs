using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet
{
    class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine($"A pet cat named {name} has been created");
            CatName = name;
            playWithPet();
        }

        public string CatName {get; }
    }
}
