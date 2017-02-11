using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVolado.GUI;

namespace SistemaVolado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sistema_Click(object sender, EventArgs e)
        {
            frm_SistemaGUI form = new frm_SistemaGUI();
            form.Show();
            this.Hide();
        }
    }
}
