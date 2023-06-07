using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celcius - °C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("_____________________________________");

            // (c * 9 / 5) + 32 = F
            f = (c * 9 / 5) + 32;
            // c + 273,15 = K
            k = c + 273.15;

            Console.WriteLine(c + " °C - Graus Celcius");
            Console.WriteLine(f + " °F - Graus Farenheit");
            Console.WriteLine(k + " °K - Graus Kelvin");
            Console.WriteLine("_______________________________________");
            Console.ReadKey();
        }
    }
}
