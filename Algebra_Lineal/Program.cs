using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_Lineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Puedes ingresar Q en cualquiera de los vectores para terminar el programa.\n");
                Console.WriteLine("Ingresa los elementos del primer vector separados por una coma. ");

                double[] a = Array.ConvertAll<string, double>(Console.ReadLine().Split(','), double.Parse);

                Console.WriteLine("Ingresa los elementos del segundo vector separados por una coma. ");

                double[] b = Array.ConvertAll<string, double>(Console.ReadLine().Split(','), double.Parse);

            double resultado;
                try
                {
                    resultado = Dot_product.dot_product.multiplicacion(a, b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se ha detectado la excepción {ex.Message}");
                    return;
                }
                Console.WriteLine($"El resultado de la suma es {resultado}");

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
        }
    }
}
