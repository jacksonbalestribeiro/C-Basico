﻿using System;

namespace operadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;//false
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;//true
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;//true
            Console.WriteLine(c3);


            Console.WriteLine("-----------------\n");

            bool c4 = 10 < 5;//false

            bool c5 = c1 || c2 && c3;//precedencia

            Console.WriteLine(c5); //true
        }
    }
}
