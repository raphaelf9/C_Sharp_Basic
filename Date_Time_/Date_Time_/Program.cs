using System;
using System.Globalization;

namespace Date_Time_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 06, 10);
            DateTime d2 = new DateTime(2022, 06, 10, 08, 54, 10);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;

            DateTime d6 = DateTime.Parse("2022-06-10"); //aceita separador barra '/'

            DateTime d7 = DateTime.ParseExact("2022-06-10", "yyyy-MM-dd",CultureInfo.InvariantCulture);

            DateTime d8 = DateTime.ParseExact("10/06/2022 09:09:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);

            Console.WriteLine(d2);

            Console.WriteLine(d3);

            Console.WriteLine(d4);

            Console.WriteLine(d5);

            Console.WriteLine(d6);

            Console.WriteLine(d7);

            Console.WriteLine(d8);


            
            
        }
    }
}
