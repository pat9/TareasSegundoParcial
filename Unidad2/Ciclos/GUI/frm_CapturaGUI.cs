using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclos.GUI
{
    public partial class frm_CapturaGUI : Form
    {
        //Variable global
        public double numeroIngresado;
        public frm_CapturaGUI()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            numeroIngresado = double.Parse(txt_Num.Text);
            txt_Num.Clear();
            txt_Num.Focus();
            this.Close();
        }
    }
}
