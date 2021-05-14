using System;

namespace exercicio_02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa:");
            int quartos  = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com proço do produto:");
            double preco = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}
