using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgebraLineal;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TAREA: Ciclarlo hasta que uno de los vectores ingresados sea "Q"
            Console.WriteLine("Ingresa los elementos del primer vector separados por una coma. ");

            //RECOGER LINEA DE TEXTO Y SEPARAR NUMEROS
            double[] a = Array.ConvertAll<string, double>(Console.ReadLine().Split(','),double.Parse);

            Console.WriteLine("Ingresa los elementos del segundo vector separados por una coma. ");
            //RECOGER LINEA DE TEXTO Y SEPARAR NUMEROS
            double[] b = Array.ConvertAll<string, double>(Console.ReadLine().Split(','), double.Parse);

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
    }
}
