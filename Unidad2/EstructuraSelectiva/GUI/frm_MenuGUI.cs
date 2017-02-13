using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructuraSelectiva.GUI;
using System.Windows.Forms;

namespace EstructuraSelectiva
{
    public partial class frm_MenuGUI : Form
    {
        public frm_MenuGUI()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void bnt_Pro1_Click(object sender, EventArgs e)
        {
            frm_ReforestacionGUI formRefor = new frm_ReforestacionGUI();
            AbrirForm(formRefor);
        }

        private void btn_Pro2_Click(object sender, EventArgs e)
        {
            frm_FruteriaGUI Fruteria = new frm_FruteriaGUI();
            AbrirForm(Fruteria);
         }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pro3_Click(object sender, EventArgs e)
        {
            frm_NumeroMedioGUI NumMed = new frm_NumeroMedioGUI();
            AbrirForm(NumMed);
        }

        private void btn_Pro4_Click(object sender, EventArgs e)
        {
            frm_SumaGUI Suma = new frm_SumaGUI();
            AbrirForm(Suma);
        }

        private void btn_Pro5_Click(object sender, EventArgs e)
        {
            frm_FactorialGUI Fact = new frm_FactorialGUI();
            AbrirForm(Fact);
        }
    }
}
