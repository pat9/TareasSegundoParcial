using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramacionEnCapas.BO;
using System.Net;

namespace ProgramacionEnCapas
{
    public partial class Form1 : Form
    {
        OperacionBO Oper = new OperacionBO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Dns.GetHostName());
            IPAddress[] LocalsIp = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in LocalsIp)
            {
                MessageBox.Show(ip.ToString());
            }
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {

            Oper.Valor1 = Convert.ToDouble(txt_Valor1.Text);
            Oper.Valor2 = Convert.ToDouble(txt_Valor2.Text);

            if (cmb_Opcion.Text == "Suma")
            {
               
                MessageBox.Show("La suma es: " + Oper.Suma());
            }
            else if(cmb_Opcion.Text == "Resta")
            {
                MessageBox.Show("La resta es: " + Oper.Resta());
            }
            else if(cmb_Opcion.Text == "Multiplicacion")
            {
                MessageBox.Show("La multiplicacion es es: " + Oper.Multiplicaion());
            }
        }
    }
}
