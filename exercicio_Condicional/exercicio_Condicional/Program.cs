using System;

namespace exercicio_Condicional {
    class Program {
        static void Main(string[] args) {

            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            
            Console.WriteLine("digite um numero inteiro");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            if(numero1 < 0) {
                Console.WriteLine(numero1 + " este numero é um negativo");
            }else if (numero1 > 0 ) {
                Console.WriteLine(numero1 + " este numero é um positivo");
            }else if(numero1 == 0) { 
                Console.WriteLine(numero1 + " este numero é zero");
            }
            

            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

            Console.WriteLine("digite um numero inteiro");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2%2 == 0) {
                Console.WriteLine(numero2 + " este numero é PAR");
            } else if (numero2 % 2 != 0) {
                Console.WriteLine(numero2 + " este numero é IMPAR");
            }
            
            /*
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            ordem crescente ou decrescente
            */

            Console.WriteLine("escreva dois numeros inteiros:");
            string[] vet3 = Console.ReadLine().Split(' ');
            int n = int.Parse(vet3[0]);
            int m = int.Parse(vet3[1]);
            int controle = 0;
            if (n < m) {
                if(m % n == 0) {
                    Console.WriteLine($"{n} e {m} são multiplos");
                }else if (m % n != 0) {
                    Console.WriteLine($"{n} e {m} não são multiplos");
                }
            }else if (n > m) {
                controle = n;
                n = m;
                m = controle;
                if (m % n == 0) {
                    Console.WriteLine($"{m} e {n} são multiplos");
                } else if (m % n != 0) {
                    Console.WriteLine($"{m} e {n} não são multiplos");
                }
            }
            
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
             começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */
            
            Console.WriteLine("informe a hora de inicio e de termeno: ");
            string[] vet4 = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(vet4[0]);
            int hora2 = int.Parse(vet4[1]);
            int qtdH = 0;

            if (hora1 < hora2) {
                hora1 = 12 - hora1;
                hora2 = hora2 - 12;
                qtdH = hora1 + hora2;
            } else if (hora1 > hora2) {
                qtdH = 24 - hora1 + hora2;
            }
            Console.WriteLine(qtdH);
            
            /*
            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar.
            */
            
            Console.WriteLine("_______________________________________");
            Console.WriteLine("cod     Epecificação           Preço   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1       Cachorro-quente        R$ 4,00");
            Console.WriteLine("2       X-salada               R$ 4,50");
            Console.WriteLine("3       X-Bacon                R$ 5,00");
            Console.WriteLine("4       Torrada simples        R$ 2,00");
            Console.WriteLine("4       Refrigerante           R$ 1,50");
            Console.WriteLine("_______________________________________\n");
           

            Console.WriteLine("Digite o codigo do pedido, e quantidade");
            string[] vet5 = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet5[0]);
            int qtd = int.Parse(vet5[1]);
            


            if (cod == 1) {
                Console.WriteLine($"Total: R${qtd * 4.00}");    
            } else if (cod == 2) {
                Console.WriteLine($"Total: R${qtd * 4.50}");
            } else if (cod == 3) {
                Console.WriteLine($"Total: R${qtd * 5.00}");
            } else if (cod == 4) {
                Console.WriteLine($"Total: R${qtd * 2.00}");
            } else if (cod == 5) {
                Console.WriteLine($"Total: R${qtd * 1.50}");
            }
            

            //quadrantes
            Console.WriteLine("digite dois valores para definir o quadrante entre -5 e 5;");
            string[] vet6 = Console.ReadLine().Split(' ');
            double x = double.Parse(vet6[0]);
            double y = double.Parse(vet6[1]);

            if (x > 0 && y > 0){
                Console.WriteLine("Q1");
            }else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x == y && x == 0) {
                Console.WriteLine("Origem");
            }


        }
    }
}
