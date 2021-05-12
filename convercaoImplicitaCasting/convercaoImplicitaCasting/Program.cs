using System;

namespace convercaoImplicitaCasting {
    class Program {
        static void Main(string[] args) {
            
            
            float x = 4.5f;
            double y = x;

            double a = 4.5;
            float b = (float)a;

            int c = (int)b;

            int ex1 = 5;
            int ex2 = 2;
            double ex3 = ex1 / ex2;

        }
    }
}
