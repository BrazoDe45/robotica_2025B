using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_To_DoubleVector
{
    public class String_tovector
    {
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
