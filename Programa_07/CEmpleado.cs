using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_07
{
    class CEmpleado
    {

        private double sueldo;
        //private double impuesto;
       

        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0}, Impuesto = {1}", sueldo, Impuesto);
        }


        public double Sueldo
        {
            get
            {
                return sueldo;
            }

            //set
            //{
            //    if (value > 5000)
            //    {
            //        sueldo = value;
            //    }
            //    else
            //        sueldo = 3000;
            //}
            set
            {
                sueldo = value > 5000 ? value : 3000;
            }
        }

        public double Impuesto { get; set; }

        //Mutator
        public void CalculaImpuesto()
        {
            Impuesto = sueldo * 0.16;
        }
    }
}
