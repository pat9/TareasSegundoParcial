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
    public partial class frm_SumaGUI : Form
    {
        SumaBO Suma = new SumaBO();
        public frm_SumaGUI()
        {
            InitializeComponent();
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txt_Num.Text);
            if (num > 0)
            {
                Suma.Num = num;
                txt_Resul.Text = Suma.Sumar().ToString();
            }
            else
            {
                MessageBox.Show("No puedes sumar numero negativos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
