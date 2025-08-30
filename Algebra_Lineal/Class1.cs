using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_Lineal
{
    public class Operadores_Vectores
    {
        //Metodos operaciones con vectores
        static public double Dot_product(double[] a, double[] b)
        {
            if (a.Length != b.Length)
                throw new Exception("Las dimensiones de los vectores no coinciden.");

            double c = 0;

            int size;

            size = a.Length;

            for (int i = 0; i < size; i++)
                c += a[i] * b[i];

            return c;
        }

        static public double[] Suma(double[] a, double[] b)
        {
            if (a.Length != b.Length)
            {
                throw new Exception("Las dimensiones de los vectores no coinciden.");
            }

            int size = a.Length;

            double[] c = new double[size];

            for (int i = 0; i < size; ++i)
            {
                c[i] = a[i] + b[i];
            }
            return c;
        }

        //Metodo para recibir un vector como string
        public static double[] StringToVector(string a)
        {
            double[] b = new double[0];
            try
            {
                b = Array.ConvertAll<string, double>(a.Split(','), double.Parse);
            }
            catch (FormatException)
            {
                throw new Exception("La cadena no contiene el formato correcto");
            }

            return b;
        }
    }
}
