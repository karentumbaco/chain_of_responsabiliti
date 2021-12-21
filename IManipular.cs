using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    interface IManipular
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
