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
    public partial class frm_FruteriaGUI : Form
    {
        FruteriaBO Fruteria = new FruteriaBO();
        public frm_FruteriaGUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Fruteria.Kilos = Convert.ToDouble(txt_Kilos.Text);
            Fruteria.PrecioKilo = Convert.ToDouble(txt_PrecioKilo.Text);

            txt_Total.Text = Fruteria.CalcularTotal().ToString();

        }
    }
}
