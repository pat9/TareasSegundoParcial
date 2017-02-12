using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva.BO
{
    class SumaBO
    {
        private double num;
        private double resultado;

        public double Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public double Sumar()
        {
            resultado = resultado + num;
            return resultado;
        }
    }
}
