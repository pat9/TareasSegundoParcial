using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVolado.BO;

namespace SistemaVolado.GUI
{
    public partial class frm_SistemaGUI : Form
    {
        MonedaBO Sistema = new MonedaBO();
        public frm_SistemaGUI()
        {
            InitializeComponent();
        }

        private void frm_SistemaGUI_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sistema.Compra = double.Parse(txt_Compra.Text);
            Sistema.Moneda = cmb_Moneda.Text;

            txt_Total.Text =  Sistema.CalculoPago().ToString();

        }

        private void btn_Regreso_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
