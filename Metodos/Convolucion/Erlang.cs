using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Metodos.Convolucion
{
    public class Erlang
    {
        private int cantidad;
        private double media;
        private int k;
        private double[] ri1;
        private double[] ri2;
        private double[] r1;
        private double[] r2;
        private double[] tiempo;

        public Erlang(int cantidad, double media, int k)
        {
            setCantidad(cantidad);
            setMedia(media);
            setK(k);
            setRi1();
            setRi2();
            setR1(cantidad);
            setR2(cantidad);
            setTiempo();
        }
        public void setCantidad(int cantidad) {
            this.cantidad = cantidad;
        }
        public double[] generarRi(int cantidad)
        {
            double[] Ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
            return Ri;
        }
        public void setMedia(double media)
        {
            this.media = media;
        }

        public void setK(int k)
        {
            this.k = k;
        }
        public void setRi1()
        {
            ri1 = generarRi(cantidad);

        }
        public void setRi2()
        {
            ri2 = generarRi(cantidad);
        }
        public void setR1(int cantidad)
        {
            r1 = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                r1[i] = 1 - ri1[i];
            }
        }

        public void setR2(int cantidad)
        {
            r2 = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                r2[i] = 1 - ri2[i];
            }
        }

        public void setTiempo()
        {
            tiempo = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                tiempo[i] = (media / k) * Math.Log(ri1[i] * ri2[i]);
            }
        }
        public int setCantidad()
        {
            return cantidad;
        }
        public double getMedia()
        {
            return media;
        }
        public int getK()
        {
            return k;
        }
        public double[] getRi1()
        {
            return ri1;
        }
        public double[] getRi2()
        {
            return ri2;
        }
        public double[] getR1()
        {
            return r1;
        }
        public double[] getR2()
        {
            return r2;
        }
        public double[] getTiempo()
        {
            return tiempo;
        }
    }
}
