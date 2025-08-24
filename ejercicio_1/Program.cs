using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AlgebraLineal;
using Dot_Product;
using String_To_Vector;

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

                double[] a =    Convertir.StringToVector(Console.ReadLine());

                Console.WriteLine("Ingresa los elementos del segundo vector separados por una coma. ");
                double[] b = Convertir.StringToVector(Console.ReadLine());

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