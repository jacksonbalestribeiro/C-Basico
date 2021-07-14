using System;

namespace Manipulando_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(1993, 11, 17, 8, 50, 45, 356);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfdWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond" + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("12) Ticks: " + d.Ticks);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("<-- outras operações -->");

            DateTime d2 = new DateTime(1977, 07, 19, 14, 15, 59);

            Console.WriteLine(d2.ToLongDateString());
            Console.WriteLine(d2.ToLongTimeString());
            Console.WriteLine(d2.ToShortDateString());
            Console.WriteLine(d2.ToShortTimeString());

            Console.WriteLine(d2.ToString());
            Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss.fff"));






        }
    }
}
