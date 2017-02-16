using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemplosHerramientas.BO;

namespace EjemplosHerramientas
{
    public partial class Form1 : Form
    {
        ImagenBO OBJ = new ImagenBO();
        MenuImagenBO obj = new MenuImagenBO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            if(chk_Raton.Checked == true)
            {
                text = chk_Raton.Text;
                MessageBox.Show("Selecciono: " + text);
            }
            else if (chk_Libreta.Checked == true)
            {
                text = chk_Libreta.Text;
                MessageBox.Show("Selecciono: " + text);
            }
            else if(chk_Internet.Checked == true)
            {
                text = chk_Internet.Text;
                MessageBox.Show("Selecciono: " + text);
            }
            else
            {
                text = chk_Imp.Text;
                MessageBox.Show("Selecciono: " + text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc_Imagen.Image = OBJ.Mostar();
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.Opcion = cmb_Opcion.Text;
            pic_Imagen.Image = obj.Mostar();
            pic_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
