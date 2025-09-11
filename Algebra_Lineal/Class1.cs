using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_Lineal
{
    public class Operadores_Matrices
    {
        //TAREA 8
        static public double[,] Suma_de_Matrices(double[,] a, double[,] b)
        {
            //CANTIDAD DE RENGLONES
            int m1 = a.GetLength(0);
            int m2 = b.GetLength(0);

            //CANTIDAD DE COLUMNAS
            int n1 = a.GetLength(1);
            int n2 = b.GetLength(1);

            if (m1 != m2 || n1 != n2)
            {
                throw new Exception("Las dimensiones de las matrices no coinciden");
            }

            double[,] c = new double[m1, n1];

            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

        //TAREA 7
        static public double[,] Multiplicacion_Matrices(double[,] a, double[,] b) 
        {
            //CANTIDAD DE RENGLONES
            int m1 = a.GetLength(0);
            int m2 = b.GetLength(0);

            //CANTIDAD DE COLUMNAS
            int n1 = a.GetLength(1);
            int n2 = b.GetLength(1);

            if (n1 != m2)
            {
                throw new Exception("Las multiplicación de matrices no es posible con las dimensiones ingresadas");
            }

            double[,] c = new double[m1, n2];

            for(int i = 0; i<m1;i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    for (int k = 0; k < n1; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;

        }
    }
    public class Operadores_Vectores
    {
        //TAREA 1 Y 2
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

        //TAREA 4 Y 5
        static public double[] ProductoCruz(double[] a, double[] b)
        {
            if (a.Length != 3 || b.Length != 3 || a.Length != b.Length)
            {
                throw new Exception("Ambos vectores deben ser de 3 dimensiones.");
            }

            double[] c = new double[3];

            c[0] = a[1] * b[2] - b[1] * a[2];
            c[1] = -(a[0] * b[2] - b[0] * a[2]);
            c[2] = a[0] * b[1] - b[0] * a[1];

            return c;
        }

        static public double Norma_Euclidiana(double[] a)
        {
            double c = 0;

            double size = a.Length;

            for (int i = 0; i < size; ++i)
                c += a[i] * a[i];

            c = Math.Abs(Math.Sqrt(c));

            return c;
        }

        //TAREA 3
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
