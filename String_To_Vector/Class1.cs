using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_To_Vector
{
    public class Convertir
    {
        public static double[] StringToVector(string a)
        {
            double[] b = new double[0];
            if (a != "Q")
            {
                try
                {
                    b = Array.ConvertAll<string, double>(a.Split(','), double.Parse);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error:La entrada contiene valores no numéricos.");
                }
            }
            else
            {
                
            }
                return b;
        }
    }
}
