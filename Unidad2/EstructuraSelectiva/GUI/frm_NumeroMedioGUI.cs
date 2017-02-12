using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstructuraSelectiva.BO;

namespace EstructuraSelectiva.GUI
{
    public partial class frm_NumeroMedioGUI : Form
    {
        NumeroMedioBO NM = new NumeroMedioBO();
        public frm_NumeroMedioGUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            NM.Num1 = double.Parse(txt_Num1.Text);
            NM.Num2 = double.Parse(txt_Num2.Text);
            NM.Num3 = double.Parse(txt_Num3.Text);

            txt_NumMedio.Text = NM.CalcularNumeroMedio().ToString();

        }
    }
}
