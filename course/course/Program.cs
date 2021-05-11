using System;

namespace course {
    class Program {
        static void Main(string[] args) {
            //tipos de variaveis
            bool completo = false;
            char genero = 'F';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "maria";
            
            //todas os tipos de variaveis vem da classe object
            object obj1 = "joao";
            object obj2 = 4.5f;

            //imprimindo na tela as variaveis
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //Pergar o valor minimo e maximo de cada tipo numerico
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

        }
    }
}
