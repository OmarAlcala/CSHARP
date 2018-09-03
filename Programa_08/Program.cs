using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int rInt = 0;
            double rDoub = 0.0;

            CCalculadora calcu = new CCalculadora();

            rInt = calcu.Suma(5, 3);

            //rDoub = calcu.Suma(5.2, 3.3);
            
            Console.WriteLine("El resultado es {0}", rInt);
            Console.WriteLine("El resultado es {0}", calcu.Suma(5.2, 3.3));

            Console.ReadKey();
        }
    }
}
