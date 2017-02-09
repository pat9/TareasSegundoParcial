using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Instrumentation;
using System.Windows.Forms;
using System.IO;
using Scanner.BO;
using System.Diagnostics;

namespace Scanner
{
    public partial class frm_Escan : Form
    {
        ScanerBO scan = new ScanerBO();
        public frm_Escan()
        {
            InitializeComponent();
            btn_Bloc.Enabled = false;
        }

        private void btn_Escanear_Click(object sender, EventArgs e)
        {
            scan.ObtenerIP();
            scan.ObtenerSubMask();

            txt_IP.Text = scan.Ip.ToString();
            txt_Red.Text = scan.Red;
            txt_Mask.Text = scan.SubMask;

            btn_Bloc.Enabled = true;

        }

        private void btn_Bloc_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = File.CreateText("C:\\Dany\\Red.txt");
            string contenido;
            contenido = "La ip es: " + scan.Ip;
            archivo.WriteLine(contenido.ToString());
            contenido = "La subMask es: " + scan.SubMask;
            archivo.WriteLine(contenido.ToString());
            contenido = "La red es:" + scan.Red;
            archivo.WriteLine(contenido.ToString());
            archivo.Flush();
            archivo.Close();
            ProcessStartInfo psi = new ProcessStartInfo("notepad.exe", "C:\\Dany\\Red.txt");
            Process p = Process.Start(psi);
        }
    }
}
