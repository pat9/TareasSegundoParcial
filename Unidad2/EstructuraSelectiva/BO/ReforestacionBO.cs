using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva.BO
{
    class ReforestacionBO
    {
        private int numHectarias;
        private int metrosCuadrados;
        private double porPino;
        private double porOyamel;
        private double porCedro;
        private double cantidadPinos;
        private double cantidadOyamenl;
        private double cantidadCedro;


        public int NumHectarias
        {
            get
            {
                return numHectarias;
            }

            set
            {
                numHectarias = value;
            }
        }

        public double PorPino
        {
            get
            {
                return porPino;
            }

            set
            {
                porPino = value;
            }
        }

        public double PorOyamel
        {
            get
            {
                return porOyamel;
            }

            set
            {
                porOyamel = value;
            }
        }

        public double PorCedro
        {
            get
            {
                return porCedro;
            }

            set
            {
                porCedro = value;
            }
        }

        public double CantidadPinos
        {
            get
            {
                return cantidadPinos;
            }

            set
            {
                cantidadPinos = value;
            }
        }

        public double CantidadOyamenl
        {
            get
            {
                return cantidadOyamenl;
            }

            set
            {
                cantidadOyamenl = value;
            }
        }

        public double CantidadCedro
        {
            get
            {
                return cantidadCedro;
            }

            set
            {
                cantidadCedro = value;
            }
        }

        public void CalcularMetros()
        {
            metrosCuadrados = numHectarias * 10000;
        }

        public void CalcularPorcentajes()
        {
            if(metrosCuadrados > 1000000)
            {
                porPino = metrosCuadrados * .70;
                porOyamel = metrosCuadrados * .20;
                porCedro = metrosCuadrados * .10;
                
            }
            else
            {
                porPino = metrosCuadrados * .50;
                porOyamel = metrosCuadrados * .30;
                porCedro = metrosCuadrados * .20;
            }
            cantidadPinos = (porPino / 10) * 8;
            cantidadOyamenl = (porPino / 15) * 15;
            cantidadCedro = (porCedro / 18) * 10;
        }
    }
}
