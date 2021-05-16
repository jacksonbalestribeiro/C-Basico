using System;
using System.Globalization;

namespace Exercicio_Sequencial {
    class Program {
        static void Main(string[] args) {

            //soma de valores:
            
            Console.WriteLine("insira o primeiro valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo valor:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1+n2);
            

            double pi = 3.14159; 
            Console.WriteLine("insira o valor do raio:");
            double n3 = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(n3, 2);
            Console.WriteLine($"Area = {area:F4} m2");
           

            Console.WriteLine("insira o primeiro valor:");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo valor:");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o terceiro valor:");
            int no3 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o quarto valor:");
            int no4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Deferença = {(no1*no2) - (no3*no4)}");
            

            Console.WriteLine("numero do cliente:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o numero de horas:");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("valor da hora trabalhada:");
            double vlrHora = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            double salario = horas * vlrHora;
            Console.WriteLine($"NUMBER = {n}\n" +
                              $"SALARY = u$ {salario.ToString("f2", CultureInfo.InvariantCulture)}");
            
            string controle = "1";
            double soma = 0;
            while (controle == "1") {
                Console.WriteLine("Insira o codigo da peça, quantidade, valor:");
                string[] vet4 = Console.ReadLine().Split(' ');
                int cod = Convert.ToInt32(vet4[0]);
                int qtd = Convert.ToInt32(vet4[1]);
                double valor = Convert.ToDouble(vet4[2], CultureInfo.InvariantCulture);
                double total = qtd * valor;
                Console.WriteLine("deseja inserir mais produtos: sim[1]/não[2]");
                controle = Console.ReadLine();
                soma += total;
            }
            Console.WriteLine($"Valor a pagar: R${soma.ToString("F2",CultureInfo.InvariantCulture)}");
            
            

            Console.WriteLine("Insira o codigo da A, B e C:");
            string[] vet = Console.ReadLine().Split(' ');
            double a = Convert.ToDouble(vet[0], CultureInfo.InvariantCulture);
            double b = Convert.ToDouble(vet[1], CultureInfo.InvariantCulture);
            double c = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);
            

            // area do triangulo
            double areaT = (a * c) / 2;
            //area do circulo
            double areaC = pi * Math.Pow(c, 2);
            //arae do trapezio
            double areaTra = (a + b)/ 2.0 * c;
            //area do quadrado
            double areaQ = Math.Pow(b, 2);
            //area do retangulo
            double areaR = a * b;

            Console.WriteLine($"TRIANGULO: {areaT.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                              $"CIRCULO: {areaC.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                              $"TRAPEZIO: {areaTra.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                              $"QUADRADO: {areaQ.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                              $"RETANGULO: {areaR.ToString("F3", CultureInfo.InvariantCulture)}\n" );


        }
    }
}
