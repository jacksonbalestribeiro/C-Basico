using System;
using System.Globalization;

namespace Aprendendp_DateTime {
    class Program {
        static void Main(string[] args) {
            
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021, 11, 25);
            DateTime d3 = new DateTime(2021, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2021, 11, 25, 20, 50, 3, 500); 
            
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            DateTime d7 = DateTime.Parse("2021-05-30");
            DateTime d8 = DateTime.Parse("2021-05-30 17:57:45");
            DateTime d9 = DateTime.Parse("15/11/2020");
            DateTime d10 = DateTime.Parse("15/11/2020 17:57:45");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2021-05-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/11/2019 17:57:45", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }
    }
}
