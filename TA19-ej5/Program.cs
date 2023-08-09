using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA19_ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;
            //--------------
            B = C;
            C = A;
            A = D;
            D = B;
            Console.WriteLine("Valor A= " + A);
            Console.WriteLine("Valor B= " + B);
            Console.WriteLine("Valor C= " + C);
            Console.WriteLine("Valor D= " + D);
            Console.ReadKey();
        }
    }
}
