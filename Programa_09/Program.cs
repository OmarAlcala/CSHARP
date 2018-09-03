using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32( Console.ReadLine());
              
            CPersona p1 = new CPersona(nombre, edad);

            //p1.Nombre = "Juan";
            //p1.Edad = 30;

            p1.muestra();

            Console.ReadKey();
        }
    }
}
