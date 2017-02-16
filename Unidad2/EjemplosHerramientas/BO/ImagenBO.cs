using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EjemplosHerramientas.BO
{
    class ImagenBO
    {
        private Image MostarImagen;

        public Image Mostar()
        {
            MostarImagen = Image.FromFile("c:\\salida-1.png");
            return MostarImagen;
        }

    }
}
