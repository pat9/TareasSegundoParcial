using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVolado.BO
{
    class MonedaBO
    {
        private double compra;
        private string moneda;
        private double total;

        public double Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }

        public double CalculoPago()
        {
            switch (moneda)
            {
                case "Sol":
                    total = compra - (compra * .20);
                    break;
                case "Aguila":
                    total = compra - (compra * .60);
                    break;
                case "Intermedio":
                    total = compra - (compra * .10);
                    break;
            }
            return total;
        }
    }
}
