using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EjemplosHerramientas.BO
{
    class MenuImagenBO
    {
        private Image MostarImagen;
        private string opcion;

        public string Opcion
        {
            get
            {
                return opcion;
            }

            set
            {
                opcion = value;
            }
        }

        public Image Mostar()
        {
            switch(opcion)
            {
                case "Niña":
                    MostarImagen = Image.FromFile("c:\\Img\\niño.jpe");
                    break;
                case "Casa":
                    MostarImagen = Image.FromFile("c:\\Img\\google.png");
                    break;
                case "Auto":
                    MostarImagen = Image.FromFile("c:\\Img\\Google_Logo_Old.png");
                    break;
                case "Computadora":
                    MostarImagen = Image.FromFile("c:\\Img\\Googlelogo.png");
                    break;
            }
            return MostarImagen;
        }
    }
}
