using System;

namespace ExercicioWhile {
    class Program {
        static void Main(string[] args) {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
              incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
              impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 
            */
            
            int senhaTrue = 2002;
            bool acesso = false;
            while (!acesso) { 
                Console.WriteLine("Digite sua senha");
                int senhaDig = int.Parse(Console.ReadLine());
                if (senhaTrue == senhaDig) {
                    acesso = true;
                    Console.WriteLine("Acesso valido!");
                } else {
                    Console.WriteLine("Senha errada!");
                }
                
            }
            
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
              cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
              menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
            */
            
            bool encerra = false;
            while (!encerra) {
                Console.WriteLine("entre com as cordenadas(x,y):");
                string[] vetor = Console.ReadLine().Split(' ');
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro q");
                }
                if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo q");
                }
                if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro q");
                }
                if (x > 0 && y < 0) {
                    Console.WriteLine("Quarto q");
                }
                if (x == 0 || y == 0) {
                    encerra = true;
                }
            
            }
            

            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
              um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
              4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
              que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
              mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
              exemplo
             */
            int somaAl = 0;
            int somaGaz = 0;
            int somaDiz = 0;
            int fim = 0;

            while (fim != 4) {
                Console.WriteLine("digite o produtro desejado:\n" +
                                  "[1/gasulina|2/alcool|3/dizel|4/sair]");
                int pedido = int.Parse(Console.ReadLine());

                if (pedido == 1) {
                    somaGaz += 1;
                }else if (pedido == 2) {
                    somaAl += 1;
                }else if (pedido == 3) {
                    somaDiz += 1;
                }else if (pedido == 4 ) {
                    fim = pedido;
                } else {
                    Console.WriteLine("Produto invalido!");
                }   
            }
            Console.WriteLine("Muito obrigado!\n" +
                             $"Alcool: {somaAl}\n" +
                             $"Gasulina: {somaGaz}\n" +
                             $"Disel: {somaDiz}");




        }
    }
}
