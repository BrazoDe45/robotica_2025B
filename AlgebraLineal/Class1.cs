using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraLineal
{
    //Hola Github :D
        public class Vectores
        {
            static public double[] Suma(double[] a, double[] b)
            {
                if (a.Length != b.Length)
                {
                    throw new Exception("Las dimensiones de los vectores no coinciden.");
                }

                //TAMAÑO VECTOR
                int size = a.Length;

                //CREAR ARREGLO PARA GUARDAR SUMA
                double[] c = new double[size];

                //REPETIR SUMA
                for (int i = 0; i < size; ++i)
                {
                    c[i] = a[i] + b[i];
                }

                return c;
            }
        }
}
