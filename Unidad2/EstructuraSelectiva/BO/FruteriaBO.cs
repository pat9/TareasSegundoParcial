using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva.BO
{
    class FruteriaBO
    {
        private double kilos;
        private double precioKilo;
        private double total;

        public double Kilos
        {
            get
            {
                return kilos;
            }

            set
            {
                kilos = value;
            }
        }

        public double PrecioKilo
        {
            get
            {
                return precioKilo;
            }

            set
            {
                precioKilo = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public double CalcularTotal()
        {
            if(kilos>=0 && kilos <= 2)
            {
                total = kilos * precioKilo;
            }
            else if(kilos >= 2.01 && kilos <= 5)
            {
                total = (kilos * precioKilo);
                total = total - (total * .10);
            }
            else if(kilos >= 5.01 && kilos <=10)
            {
                total = (kilos * precioKilo) - ((kilos * precioKilo) * .15);
            }
            else
            {
                total = (kilos * precioKilo) - ((kilos * precioKilo) * .20);
            }
            return total;
        }

    }
}
