using System;

namespace Time_Span_Prop_Ops
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine("Duração máxima possível de ser armazenada no TimeSpan: " + t1);

            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine("Duração mínima possível de ser armazenada no TimeSpan: " + t2);

            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("Duração Zero do TimeSpan: " + t3);

            TimeSpan t = new TimeSpan(2, 3, 4, 5, 600);

            Console.WriteLine("TimeSpan T: " + t);
            Console.WriteLine("Dias no TimeSpan T: " + t.Days);
            Console.WriteLine("Horas no TimeSpan T: " + t.Hours);
            Console.WriteLine("Minutos no TimeSpan T: " + t.Minutes);
            Console.WriteLine("Segundos no TimeSpan T: " + t.Seconds);
            Console.WriteLine("Milisegundos no TimeSpan T: " + t.Milliseconds);
            Console.WriteLine("Ticks no TimeSpan T: " + t.Ticks);
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("TotalDays no TimeSpan T: " + t.TotalDays);
            Console.WriteLine("TotalHours no TimeSpan T: " + t.TotalHours);
            Console.WriteLine("TotalMinutes no TimeSpan T: " + t.TotalMinutes);
            Console.WriteLine("TotalSecond no TimeSpan T: " + t.TotalSeconds);
            Console.WriteLine("TotalMiliseconds no TimeSpan T: " + t.TotalMilliseconds);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("Operações com Timespan:");

            TimeSpan t4 = new TimeSpan(1, 30, 20);
            TimeSpan t5 = new TimeSpan(0, 10, 15);

            TimeSpan soma = t4.Add(t5);
            TimeSpan sub = t4.Subtract(t5);
            TimeSpan mult = t4.Multiply(2.0);
            TimeSpan div = t4.Divide(2.0);



            Console.WriteLine("TimeSpan T4: " + t4);
            Console.WriteLine("TimeSpan T5: " + t5);
            Console.WriteLine("TimeSpan T4 + T5: " + soma);
            Console.WriteLine("TimeSpan T4 - T5: " + sub);
            Console.WriteLine("TimeSpan T4 * 2: " + mult);
            Console.WriteLine("TimeSpan T4 / 2: " + div);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("DateTimeKind:");
            DateTime d1 = DateTime.Now;

            Console.WriteLine("DateTime Agora:" + d1);
            Console.WriteLine("DateTime para UTC: " + d1.ToUniversalTime());
            Console.WriteLine("DateTime Local: " + d1.ToLocalTime());
            Console.WriteLine("Tipo do DateTime: " + d1.Kind);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("ISO 8601:");


        }

    }
}
