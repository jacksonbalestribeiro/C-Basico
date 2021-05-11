using System;
using System.Globalization;

namespace saidaDeDados {
    class Program {
        static void Main(string[] args) {
            
            //saida comum
            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("boa noite!");
            Console.WriteLine("<------->");

            //Saida de variaveis
            char genero = 'F';
            int idade = 32;
            double saldo = 100.578941;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);

            //Placeholders, concatenção e interpolação
            Console.WriteLine("<------------>");
            Console.WriteLine("{0} tem {1} anos de e tem slado igual a {2:F2}", nome, idade, saldo);

            Console.WriteLine("<------------>");
            Console.WriteLine(nome +" Tem "+ idade +", de genero "+ genero + " Com salso de "+ saldo.ToString("F2"));

            Console.WriteLine("<------------>");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2")} R$");

            Console.WriteLine("testando meu repositorio");
        }
    }
}
