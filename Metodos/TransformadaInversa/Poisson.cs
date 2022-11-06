using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Metodos.TransformadaInversa
{
    public class Poisson
    {
        private int cantidad;
        private int pieza;
        private double[] pX;
        private double[] PX;
        private double[,] decision;

        public Poisson(int cantidad, int pieza)
        {
            setCantidad(cantidad);
            setPieza(pieza);
            setpX();
            setPX();
            setDecision();
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public void setPieza(int pieza)
        {
            this.pieza = pieza;

        }
        public void setpX()
        {
            pX = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                pX[i] = (Math.Pow(pieza, i) * Math.Exp(pieza)) / factorial(i);
            }
        }

        public void setPX()
        {
            PX = new double[cantidad];
            PX[0] = pX[0];
            for (int i = 1; i < cantidad; i++)
            {
                PX[i] = pX[i] + pX[i - 1];
            }
        }
        public void setDecision()
        {
            decision = new double[cantidad, 2];
            decision[0, 0] = 0;
            decision[0, 1] = PX[0];
            for (int i = 1; i < cantidad; i++)
            {
                decision[i, 0] = decision[i - 1, 1];
                decision[i, 1] = PX[i];
            }
        }
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public int getPieza()
        {
            return pieza;
        }

        public double[] getpX()
        {
            return pX;
        }
        public double[] getPX()
        {
            return PX;
        }
        public double[,] getDecision()
        {
            return decision;
        }
    }
}
