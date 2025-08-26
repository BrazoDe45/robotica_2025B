using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_Vectores
{
    public class Multiplicacion_vectores
    {
        static public double multiplicacion(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
                throw new Exception("Las dimensiones de los vectores no coinciden.");

            double resultado = 0;

            int size;

            size = v1.Length;

            for (int i = 0; i < size; i++)
                resultado += v1[i] * v2[i];

            return resultado;
        }
    }
}
