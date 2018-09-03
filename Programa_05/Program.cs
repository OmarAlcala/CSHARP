using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_05
{
    class Program
    {
        static void Main(string[] args)
        {

            double impuesto = 0.0;

            CEmpleado Juan = new CEmpleado();
            Juan.Muestra();
            Juan.set_sueldo(10500.50);

            Juan.Muestra();
            Juan.CalculaImpuesto();

            impuesto = Juan.get_impuesto();
            Console.WriteLine("El impuesto es de {0}", impuesto);
            Juan.Muestra();

            Console.ReadKey();
        }
    }
}
