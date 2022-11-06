using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Metodos.TransformadaInversa
{
    public class Exponencial
    {

        private int media;
        private int cantidad;
        private double[] Ri;
        private double[] Xi;

        public Exponencial(int media, int cantidad)
        {
            setMedia(media);
            setCantidad(cantidad);
            setRi();
            setXi();

        }
        public void setMedia(int media)
        {
            this.media = media;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setRi()
        {
            Ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
        }

        public void setXi()
        {
            Xi = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Xi[i] = -media * Math.Log(1 - Ri[i]);
            }
        }

        public int getMedia()
        {
            return media;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public double[] getRi()
        {
            return Ri;
        }

        public double[] getXi()
        {
            return Xi;
        }

        public string[] toString()
        {
            string[] cadenas = new string[cantidad];
            for(int i = 0; i < cantidad; i++)
            {
                cadenas[i] = Ri[i] + "," + Xi[i];
            }
            return cadenas;
        }
    }
}
