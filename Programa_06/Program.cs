using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos El objeto

            CEmpleado Juan = new CEmpleado();

            Juan.set_sueldo(7800);
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.Muestralog();

            Console.WriteLine("------------");

            CEmpleado Jose = new CEmpleado();
            Jose.set_sueldo(50000);
            Jose.set_sueldo(1000000);
            Jose.set_sueldo(10000);

            Console.WriteLine("El sueldo de Jose es {0}", Jose.get_sueldo(12));
            Jose.Muestra();
            Jose.Muestralog();

            Console.ReadKey();
        
        }
    }
}
