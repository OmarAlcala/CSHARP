using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCalculadora
{
    class Calculadora
    {
        public double a;
        public double b;
        public double r;

        public void Suma()
        {
            r = a + b;
        }
            
        public void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r = {r}", a, b, r);
        }

        public int MyProperty { get; set; }


    }
}
