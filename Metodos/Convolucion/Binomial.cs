using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Metodos.Convolucion
{
    public class Binomial
    {
        private int cantidad;
        private double[] Ri;
        private double[] B1;
        private string[] decision;
        private double defectuoso;
        private int[] pieza;

        public Binomial(double defectuoso, int cantidad, int[] pieza)
        {
            setCantidad(cantidad);
            setRi(cantidad);
            setDefectuso(defectuoso);
            setPieza(pieza);
            getB1();
            setDecision();

        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setRi(int cantidad)
        {
            Ri = GenerarRi(cantidad);
        }

        public void setDefectuso(double defectuoso)
        {
            this.defectuoso = defectuoso;
        }
        public void setPieza(int[] pieza)
        {
            this.pieza = pieza;
        }

        public double[] GenerarRi(int cantidad)
        {
            double[] Ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
            return Ri;
        }

        public void setB1()
        {
            double x = 1 - defectuoso;
            B1 = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                double a = Ri[i];
                if (a <= x)
                {
                    B1[i] = 0;
                }
                else
                {
                    B1[i] = 1;
                }
            }
        }

        public void setDecision()
        {
            decision = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                if (pieza[i] == 0)
                {
                    decision[i] = "No falla";
                }
                else
                {
                    decision[i] = "Falla";
                }
            }
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public double getDefectuoso()
        {
            return defectuoso;
        }

        public int[] getPieza()
        {
            return pieza;
        }
        public double[] getRi()
        {
            return Ri;
        }

        public double[] getB1()
        {
            return B1;
        }

        public string[] getDesision()
        {
            return decision;
        }
    }
}
