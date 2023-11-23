using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropotypeFormas.Instanciables
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            Name = "Triangle";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle with id: {Id}");
        }
    }
}
