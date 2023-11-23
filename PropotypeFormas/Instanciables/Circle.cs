using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropotypeFormas.Instanciables
{
    public class Circle : Shape
    {
        public Circle()
        {
            Name = "Circle";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with id: {Id}");
        }
    }
}
