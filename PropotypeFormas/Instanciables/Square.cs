using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropotypeFormas.Instanciables
{
    public class Square : Shape
    {
        public Square()
        {
            Name = "Square";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a square with id: {Id}");
        }
    }
}
