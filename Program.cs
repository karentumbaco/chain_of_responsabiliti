using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la cadena
            Propietario elPropietario = new Propietario();
            Jefe eljefe = new Jefe(elPropietario);
            Vendedora elVendedor = new Vendedora (eljefe);

            int cantidad = 50;
            double precio = 1000;
            double total = 0;

            total = elVendedor.CalculaPrecioFinal(cantidad, precio);

            Console.WriteLine("total {0}, con descuento {1}", cantidad * precio, total);
            Console.ReadLine();
        }
    }
}
