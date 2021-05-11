using System;
using System.Globalization;

namespace Exercicio_01 {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234568;


            Console.WriteLine("Produtos");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2")}");
            
            Console.WriteLine(" ");
            Console.WriteLine($"Registro {idade} anos de idade, codigo {codigo} e gênero: {genero}");

            Console.WriteLine(" ");
            Console.WriteLine($"Medida com 8 casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondando com 3 casas decimais: {medida.ToString("F3")}");
            Console.WriteLine($"Arredondando com 3 casas invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
