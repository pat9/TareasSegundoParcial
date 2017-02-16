using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciclos.GUI;

namespace Ciclos.BO
{
    class PromedioBO
    {
        private double prom;
        private int numCalf;
        private int conta = 1;
        private double acSuma;

        public int NumCalf
        {
            get
            {
                return numCalf;
            }

            set
            {
                numCalf = value;
            }
        }

        frm_CapturaGUI frm_Capt = new frm_CapturaGUI();

        public double promedioCal()
        {
            while(conta <= numCalf)
            {
                conta++;
                frm_Capt.ShowDialog();
                acSuma += frm_Capt.numeroIngresado;
            }
            prom = acSuma / numCalf;
            return prom;
        }
    }
}
