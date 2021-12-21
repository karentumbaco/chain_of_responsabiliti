using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    class Propietario : IManipular
    {
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {

            Console.WriteLine("Ahora esta con el propietario");
            double total = 0;

            // Damos 15% de descuento
            total = pCantidad * pPrecio * 0.85;

            return total;
        }
    }
}
