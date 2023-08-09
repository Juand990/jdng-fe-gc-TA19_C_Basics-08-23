using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA19_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 3;
            int Y = 6;
            double N = 4;
            double M = 8;

            Console.WriteLine("Variable X= " + X);
            Console.WriteLine("Variable Y= " + Y);
            Console.WriteLine("Variable N= " + N);
            Console.WriteLine("Variable M= " + M);
            Console.WriteLine("------------------------");
            Console.WriteLine("Suma X+Y= " + (X + Y));
            Console.WriteLine("Diferencia X-Y= " + (X - Y));
            Console.WriteLine("Producto X*Y= " + (X * Y));
            Console.WriteLine("Cociente X/Y= " + (X / Y));
            Console.WriteLine("Resto X%Y= " + (X % Y));
            Console.WriteLine("------------------------");
            Console.WriteLine("Suma N+M= " + (N + M));
            Console.WriteLine("Diferencia N-M= " + (N - M));
            Console.WriteLine("Producto N*M= " + (N * M));
            Console.WriteLine("Cociente N/M= " + (N / M));
            Console.WriteLine("Resto N%M= " + (N % M));
            Console.WriteLine("------------------------");
            Console.WriteLine("Suma X+N= " + (X+N));
            Console.WriteLine("Cociente Y/M= " + (Y/M));
            Console.WriteLine("Resto Y%M= " + (Y % M));
            Console.WriteLine("------------------------");
            Console.WriteLine("Doble de X= "+X*2);
            Console.WriteLine("Doble de Y= "+Y*2);
            Console.WriteLine("Doble de N= "+N*2);
            Console.WriteLine("Doble de M= "+M*2);
            Console.WriteLine("------------------------");
            Console.WriteLine("Suma de variables= " + (X + Y + N + M));
            Console.WriteLine("Producto de variables= "+(X*Y*N*M));
            Console.ReadKey();
        }
    }
}
