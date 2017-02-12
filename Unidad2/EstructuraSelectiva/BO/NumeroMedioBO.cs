using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva.BO
{
    class NumeroMedioBO
    {
        private double num1;
        private double num2;
        private double num3;
        private double numeroMedio;

        public double Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }

        public double Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public double Num3
        {
            get
            {
                return num3;
            }

            set
            {
                num3 = value;
            }
        }

        public double CalcularNumeroMedio()
        {
            if(num1 > num2 && num2 < num3)
            {
                numeroMedio = num2;
            }
            else if ( num2 > num1 && Num1 < num3)
            {
                numeroMedio = num1;
            }
            else
            {
                numeroMedio = num3;
            }
            return numeroMedio;
        }

    }
}
