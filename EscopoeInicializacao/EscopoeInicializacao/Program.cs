using System;

namespace EscopoeInicializacao {
    class Program {
        static void Main(string[] args) {


            //Voce não pode tentar usar uma variavel sem iniciala!
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x + "\n");

            //Não posso imprimir nem usar a variavel desconto pois esta restrita 
            //ao conteudo do "IF"
            double preco = double.Parse(Console.ReadLine());
            if (preco > 100.00) {
                double desconto = preco * 0.1;
                preco -= desconto;
            }
            //Console.WriteLine(desconto);
            Console.WriteLine(preco.ToString("F2"));
        }
    }
}
