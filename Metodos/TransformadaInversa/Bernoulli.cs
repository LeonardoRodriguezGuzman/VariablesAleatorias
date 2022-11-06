using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Metodos.TransformadaInversa
{
    public class Bernoulli
    {
        private int cantidad;
        private int probabilidad;
        private double pX;
        private double[] Ri;
        private double[] Xi;
        private string[] evento;

        public Bernoulli(int cantidad, int probabilidad)
        {
            setCantidad(cantidad);
            setProbabilidad(probabilidad);
            setpX();
            setRi();
            setXi();
            setEvento();
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public void setProbabilidad(int probabilidad)
        {
            this.probabilidad = probabilidad;
        }
        public void setpX()
        {
            this.pX = 1 - probabilidad;
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
                if (Ri[i] <= pX)
                {
                    Xi[i] = 0;
                }
                else
                {
                    Xi[i] = 1;
                }

            }
        }

        public void setEvento()
        {
            evento = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                if (Xi[i] == 0)
                {
                    evento[i] = "No Falla";
                }
                else
                {
                    evento[i] = "Falla";
                }
            }
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public int getProbabilidad()
        {
            return probabilidad;
        }
        public double getpX()
        {
            return pX;
        }

        public double[] getRi()
        {
            return Ri;
        }

        public double[] getXi()
        {
            return Xi;
        }

        public string[] getEvento()
        {
            return evento;
        }

        public string[] toString()
        {
            string[] cadenas = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                cadenas[i] = Ri[i] + "," + Xi[i]+"," +evento[i];
            }
            return cadenas;
        }
    }
}
