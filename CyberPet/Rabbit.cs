using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet
{
    class Rabbit : Pet
    {
        public Rabbit(string name) : base(name)
        {
            Console.WriteLine($"A pet rabbit named {name} has been created");
            RabbitName = name;
            playWithPet();
        }
        public string RabbitName { get; }
    }
}
