using System;
using System.Globalization;

namespace entradaDeDados {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
           
            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
            

            Console.WriteLine("Digite o numero intero:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um caracter: ");
            string s = Console.ReadLine();
            Console.WriteLine("Digitre um double: ");
            double d = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.WriteLine(d.ToString(CultureInfo.InvariantCulture));
           
            string[] vet2 = Console.ReadLine().Split(' ');
            string nome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            
            Console.WriteLine($"nome :{nome} ," +
                              $"sexo {sexo}, idae: {idade}, " +
                              $"altura: {altura.ToString(CultureInfo.InvariantCulture)}");
            




        }
    }
}
