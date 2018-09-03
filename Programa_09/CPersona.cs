using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona(string pnombre, int pedad)
        {
            //Console.WriteLine("Estamos en el Constructor");
            //nombre = "";
            //edad = 0;

            //Console.WriteLine("Estamos en el Constructor");
            //Console.WriteLine("Dame el nombre: ");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Dame la edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());

            nombre = pnombre;
            pedad = edad;
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
        }

        public void muestra()
        {

            Console.WriteLine("Nombre = {0}, Edad = {1}", nombre, edad);
        }


    }
}
