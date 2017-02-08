using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEnCapas.BO
{
    class OperacionBO
    {
        private double valor1;
        private double valor2;
        private double resultado;

        public double Valor1
        {
            get
            {
                return valor1;
            }

            set
            {
                valor1 = value;
            }
        }

        public double Valor2
        {
            get
            {
                return valor2;
            }

            set
            {
                valor2 = value;
            }
        }

        public double Suma()
        {
            resultado = valor1 + valor2;
            return resultado;
        }

        public double Resta()
        {
            resultado = valor1 - valor1;
            return resultado;
        }

        public double Multiplicaion()
        {
            resultado = valor1 * valor2;
            return resultado;
        }

    }
}
