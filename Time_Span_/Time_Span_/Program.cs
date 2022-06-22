using System;
using System.Globalization;

namespace Time_Span_
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime = tempo && TimeSpan = duração (intervalo entre tempos)
            //TimeSpan = tipo valor(struct)

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L); //L = long
            TimeSpan t3 = new TimeSpan(01, 02, 03); //hora, minuto, segundo
            TimeSpan t4 = new TimeSpan(1, 02, 22, 12); //dia, hora, minuto, segundo
            TimeSpan t5 = new TimeSpan(2, 03, 44, 55, 666); //dia, hora, minuto, segundo, milisegundo

            TimeSpan t6 = TimeSpan.FromDays(1.5); // Um dia e 12h
            TimeSpan t7 = TimeSpan.FromHours(1.5); // Uma hora e meia
            TimeSpan t8 = TimeSpan.FromMinutes(1.5); //Um minuto e meio
            TimeSpan t9 = TimeSpan.FromSeconds(1.5); // Um segundo e meio
            TimeSpan t10 = TimeSpan.FromMilliseconds(1); //500 milisegundos
            TimeSpan t11 = TimeSpan.FromTicks(900000000L); //900 milhões de ticks

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);


        }
    }
}
