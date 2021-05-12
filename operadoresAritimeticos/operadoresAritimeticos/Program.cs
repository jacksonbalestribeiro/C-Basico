using System;

namespace operadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3 + 4 * 2;
            int n1 = (3 + 4) * 2;
            int n2 = 17 % 3;
            double n4 = 10.00 / 8;

            Console.WriteLine(n);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n4);// presisa ser incado double se não há quebra
            Console.WriteLine("<------------------------------------->");

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b,2.0) - 4.0 * a * c;

            double x1 = (-(b) + Math.Sqrt(delta)) / 2.0 * a;
            double x2 = (-(b) - Math.Sqrt(delta)) / 2.0 * a;

            Console.WriteLine($"Meu delta é {delta}, x1 = {x1}, x2 = {x2}");



        }
    }
}
