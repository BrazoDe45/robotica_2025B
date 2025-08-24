using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AlgebraLineal;
using Dot_Product;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //TAREA: Ciclarlo hasta que uno de los vectores ingresados sea "Q"
                Console.WriteLine("Puedes ingresar Q en cualquiera de los vectores para terminar el programa.\n");
                Console.WriteLine("Ingresa los elementos del primer vector separados por una coma. ");

                string[] a_str = Console.ReadLine().Split(',');
                if (a_str[0] == "Q")
                    break;

                //RECOGER LINEA DE TEXTO Y SEPARAR NUMEROS
                double[] a = Array.ConvertAll<string, double>(a_str, double.Parse);

                Console.WriteLine("Ingresa los elementos del segundo vector separados por una coma. ");
                //RECOGER LINEA DE TEXTO Y SEPARAR NUMEROS
                string[] b_str = Console.ReadLine().Split(',');
                if (b_str[0] == "Q")
                    break;

                double[] b = Array.ConvertAll<string, double>(b_str, double.Parse);

                /*
                //REALIZAR SUMA DE VECTORES
                double[] c;
                try
                {
                    c = Vectores.Suma(a, b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se ha detectado la excepción {ex.Message}");
                    return;
                }
                Console.WriteLine("El resultado de la suma es ");
                Console.WriteLine(String.Join(", ", c));
            }
                */

                //REALIZAR MULTIPLICACION DE VECTORES
                double resultado_multiplicacion;
                try
                {
                    resultado_multiplicacion = Dot_Product.Dot_Product.multiplicacion(a, b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se ha detectado la excepción {ex.Message}");
                    return;
                }
                Console.WriteLine($"El resultado de la suma es {resultado_multiplicacion}");

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}