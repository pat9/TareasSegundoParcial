using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciclos.BO;

namespace Ciclos
{
    public partial class frm_PromGUI : Form
    {
        PromedioBO prom = new PromedioBO();
        public frm_PromGUI()
        {
            InitializeComponent();
        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            prom.NumCalf = int.Parse(txt_Num.Text);
            txt_Prom.Text = prom.promedioCal().ToString();
        }
    }
}
