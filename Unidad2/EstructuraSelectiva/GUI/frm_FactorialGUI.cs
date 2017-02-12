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
    public partial class frm_FactorialGUI : Form
    {
        FactorialBO Fact = new FactorialBO();
        public frm_FactorialGUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Fact.Num = int.Parse(txt_Num.Text);
            txt_Resultado.Text = Fact.CalcularFactorial().ToString();
        }
    }
}
