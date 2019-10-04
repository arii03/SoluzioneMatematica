using System;

namespace LibreriaMatematica
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Sottrazione(int n1, int n2)
        {
            int d = n1 - n2;
            return d;
        }
        public static double Divisione(double n1, double n2)
        {
            if (n2 == 0)
            {


                throw new Exception("Divisione con zero non valida");
            }
            double q = n1 / n2;
            return q;
        }

        public static double Max(double n1, double n2)
        {
            double ma;
            if (n1 >= n2)
            {
                ma = n1;
            } else
            {
                ma = n2;

            }
            return ma;
        }
        public static double Min(double n1, double n2)
        {
            double mi;
            if (n1 <= n2)
            {
                mi = n1;
            }
            else
            {
                mi = n2;

            }
            return mi;
        }
        public static double Potenza(double n1, double n2)
        {
            int contatore = 0;
            do
            {
                n1 = n1 * n1;
                contatore++;
            } while (contatore < n2);
            return n1;
        }

    }
}
