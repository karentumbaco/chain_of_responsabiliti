using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    class Jefe : IManipular
    {
        private IManipular siguiente = null;
        public Jefe (IManipular pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Usted se encuentra con el jefe");
            // Si son mas de 100 articulos o mas de 75000 en ventas
            // pasa al propietario
            double total = pCantidad * pPrecio;

            if (pCantidad > 100 || total > 75000)
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            else
            {
                // Damos el 10% de descuento
                if (pCantidad > 20)
                    total *= 0.9;

            }

            return total;

        }
    }
}
