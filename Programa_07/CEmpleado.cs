﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_07
{
    class CEmpleado
    {

        private double sueldo;
        private double impuesto;
        private string log;

        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0}, Impuesto = {1}", sueldo, impuesto);
        }
        //Accesors get y set

        public void set_sueldo(double pSueldo)
        {
            if (pSueldo < 500 || pSueldo > 15000)
            {
                LogError("Sueldo ilegal " + pSueldo.ToString());
            }
            else
            {
                sueldo = pSueldo;
            }
        }
        public double get_sueldo(int pPassword)
        {
            if (pPassword != 123456)
            {
                LogError("Password Ilegal");
                return 0.0;
            }
            else
            {
                return sueldo;
            }
        }
        public double get_impuesto(int pPassword)
        {
            if (pPassword != 123456)
            {
                LogError("Password Ilegal");
                return 0.0;
            }
            else
            {
                return impuesto;
            }
        }
        //Mutator
        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }

        private void LogError(string pError)
        {
            log += pError + "\r\n";

        }

        public void Muestralog()
        {
            Console.WriteLine(log);
        }
    }
}
