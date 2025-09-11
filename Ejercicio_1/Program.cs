using Algebra_Lineal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = Matrix.StringToMatrix();
            double[,] B = Matrix.StringToMatrix();
            double[,] resultado_suma = new double[0, 0];
            Console.WriteLine();
            try
            {
               resultado_suma = Matrix.Multiplicacion_Matrices(A, B);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error detectado: {ex.ToString()}");
            }

            //m1 x n1 * m2 x n2 = m1 x n2
            int m = resultado_suma.GetLength(0);
            int n = resultado_suma.GetLength(1);
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"{resultado_suma[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
