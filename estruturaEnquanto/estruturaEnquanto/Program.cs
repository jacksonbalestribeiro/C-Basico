using System;

namespace estruturaEnquanto {
    class Program {
        static void Main(string[] args) {

            double numero = 1;
            double resultado = 0;
            while (numero > 0) {
                Console.WriteLine("Escreva o numero que voce quer a raiz quadrada:");
                numero = double.Parse(Console.ReadLine());
                if (numero < 0) {
                    Console.WriteLine("numero {0} negativo", numero);
                } else {
                    resultado = Math.Sqrt(numero);
                    Console.WriteLine("Raiz quadrada de {0} = {1} ", numero, resultado.ToString("F3"));
                }
            }


        }
    }
}