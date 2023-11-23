using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMonsters.Instanciables
{
    public class Vampire : Monster
    {
        public Vampire()
        {
            Name = "Vampire";
        }
        public int Bloodlust { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Vampire with id {Id} starting to attack");
        }
    }
}
