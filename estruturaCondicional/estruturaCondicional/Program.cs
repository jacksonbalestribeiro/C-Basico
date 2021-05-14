using System;

namespace estruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = 5;

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if (hora < 18)
            {
                Console.WriteLine("Bom tarde!");
            }
            else
            {
                Console.WriteLine("Bom noite!");
            }

            Console.WriteLine("----------------------------\n");


            Console.WriteLine("entre com um numero inteiro:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            if ((x2 % 2) == 0)
            {
                Console.WriteLine("Este numero é PAR");
            }
            else
            {
                Console.WriteLine("Este numeor é Impar");
            }
            
            
        }
    }
}
