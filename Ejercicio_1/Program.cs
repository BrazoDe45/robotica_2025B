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
            double[,] a = { { 4, 5 }, { 2, 3 } };
            double[,] b = { { 3, 2 }, { 1, 2 } };

            double[,] c = Operadores_Matrices.Multiplicacion_Matrices(a, b);
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            /*
            while (true)
            {
                
                Console.WriteLine("Puedes ingresar Q en cualquiera de los vectores para terminar el programa.\n");
                Console.WriteLine("Ingresa los elementos del primer vector separados por una coma. ");

                string a_str = Console.ReadLine();
                if (a_str == "Q")
                    break;

                double[] a = Operadores_Vectores.StringToVector(a_str);

                Console.WriteLine("Ingresa los elementos del segundo vector separados por una coma. ");

                string b_str = Console.ReadLine();
                if (b_str == "Q")
                    break;

                double[] b = Operadores_Vectores.StringToVector(a_str);

                double resultado_multiplicacion;
                try
                {
                    resultado_multiplicacion = Operadores_Vectores.Dot_product(a, b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se ha detectado la excepción {ex.Message}");
                    return;
                }
                Console.WriteLine($"El resultado de la suma es {resultado_multiplicacion}");

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey()
            }
            */
        }
    }
}
