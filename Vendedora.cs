using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    class Vendedora : IManipular
    {
        private IManipular siguiente = null;

        public Vendedora (IManipular pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("///Con el vendedor///");

            // Si son mas de 20 articulos o mas de 20000 en ventas
            // pasa al jefe de piso
            double total = pCantidad * pPrecio;

            if (pCantidad > 20 || total > 20000)
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            else
            {
                // Si son mas de 10 damos un 5% de descuento
                if (pCantidad > 10)
                    total *= 0.95;
            }
            return total;
        }
    }
}
