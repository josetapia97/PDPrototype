using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMonsters.Instanciables
{
    public class Zombie : Monster
    {
        public Zombie()
        {
            Name = "Zombie";
        }
        public int Health { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Zombie with id {Id} starting to attack");
        }
    }
}
