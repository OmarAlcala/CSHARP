using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcu = new Calculadora();

            calcu.a = 5;
            calcu.b = 5;

            calcu.Suma();

            calcu.Muestra(); 

        }
        
    }
}
