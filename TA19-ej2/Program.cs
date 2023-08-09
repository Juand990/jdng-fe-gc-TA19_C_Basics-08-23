using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA19_ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            double A = 2.5;
            char C = 'a';
            Console.WriteLine("variable N="+N);
            Console.WriteLine("variable A=" + A);
            Console.WriteLine("variable C=" + C);
            Console.WriteLine("Suma N+A="+(N+A));
            Console.WriteLine("Diferencia A-N="+(A-N));
            Console.WriteLine("Valor numerico de C=" + (int)C);
            Console.ReadKey();
        }
    }
}
