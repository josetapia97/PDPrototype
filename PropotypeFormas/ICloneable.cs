using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropotypeFormas
{
    public interface ICloneable
    {
        //object es la clase base de .net, es una referencia a un objeto cualquiera.
        object Clone();
    }
}
