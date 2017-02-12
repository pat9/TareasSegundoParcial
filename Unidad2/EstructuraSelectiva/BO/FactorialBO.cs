using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva.BO
{
    class FactorialBO
    {
        private int num;
        private int res;

        public  int Num
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

        public int  CalcularFactorial()
        {
            res = num;
            for (int c = num - 1; c > 0; c--)
            {
                res = res * c;
            }
            return res;
        }

    }
}
