using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA19_ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 10;
            int valor2 = 5;

            Console.WriteLine("SUMA");
            Console.WriteLine(valor1 + valor2);
            Console.WriteLine("RESTA");
            Console.WriteLine(valor1 - valor2);
            Console.WriteLine("MULT");
            Console.WriteLine(valor1 * valor2);
            Console.WriteLine("DIV");
            Console.WriteLine(valor1 / valor2);
            Console.WriteLine("MODULO");
            Console.WriteLine(valor1 % valor2);
            Console.ReadKey();
        }
    }
}
