using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMonsters.Instanciables
{
    public class Mummy : Monster
    {
        public Mummy()
        {
            Name = "Mummy";
        }
        public int Bandage { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Mommy with id {Id} starting to attack");
        }
    }
}
