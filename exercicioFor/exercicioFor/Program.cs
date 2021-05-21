using System;

namespace exercicioFor {
    class Program {
        static void Main(string[] args) {
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, 
             inclusive o X, se for o caso.
            */
            
            Console.WriteLine("Digite um valor:");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 1; i <= valor; i++) {
                if(i%2 != 0) {
                    Console.WriteLine($"{i}");
                }
            }
            
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
              Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
              essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */
            
            Console.WriteLine("Digite um numero para as repetições");
            int n = int.Parse(Console.ReadLine());
            int SomaIn = 0;
            int SomaOut = 0;
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite um numero para tetse");
                int teste = int.Parse(Console.ReadLine());
                if (teste >= 10 && teste <=20) {
                    SomaIn += 1;
                }else {
                    SomaOut += 1;
                }
            }
            Console.WriteLine($"{SomaIn} in");
            Console.WriteLine($"{SomaOut} in");
            
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
              Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
              essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */

            Console.WriteLine("Digite o numero de repetições:");
            int rep = int.Parse(Console.ReadLine());
            double[] result = new double[rep];
            for (int i = 0; i < rep; i++) {
                Console.WriteLine("Digite os valores para o calculo:");
                string[] str = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(str[0]);
                double nota2 = double.Parse(str[1]);
                double nota3 = double.Parse(str[2]);
                result[i] = ((nota1 * 2) + (nota3 * 3) + (nota3 * 5)) / (1+2+3);
            }
            for (int i= 0; i<result.Length;i++) {
                Console.WriteLine($"{result[i].ToString("F1")}");
            }

        }
    }
}
