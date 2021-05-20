using System;

namespace estruturaFor {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Quantos numeros inteiros voce quer digitar?");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < qtd; i++) {
                Console.Write($"Valor #{i+1}:");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
