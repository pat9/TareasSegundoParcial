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
    public partial class frm_ReforestacionGUI : Form
    {
        ReforestacionBO refor = new ReforestacionBO();
        public frm_ReforestacionGUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            refor.NumHectarias = Convert.ToInt32(txt_Hectareas.Text);

            refor.CalcularMetros();
            refor.CalcularPorcentajes();

            txt_PorCedro.Text = refor.PorCedro.ToString();
            txt_PorOyamel.Text = refor.PorOyamel.ToString();
            txt_PorPino.Text = refor.PorPino.ToString();
            txt_CantCedro.Text = refor.CantidadCedro.ToString();
            txt_CantOyamel.Text = refor.CantidadOyamenl.ToString();
            txt_CantPino.Text = refor.CantidadPinos.ToString();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_MenuGUI form = new frm_MenuGUI();
            form.Show();
            this.Hide();
        }
    }
}
