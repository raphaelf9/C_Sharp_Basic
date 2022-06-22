using System;

namespace Date_Time_Ops_Props
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 06, 10, 09, 51, 12, 500);

            Console.WriteLine("DateTime definido: "+ d1);
            Console.WriteLine("1- Data com horas zeradas: "+ d1.Date);
            Console.WriteLine("Tipo: "+ d1.Kind);
            Console.WriteLine("2- Dia: "+ d1.Day);
            Console.WriteLine("3 - Mês: "+ d1.Month);
            Console.WriteLine("4 - Ano: "+ d1.Year);
            Console.WriteLine("5 - Horas: "+ d1.Hour);
            Console.WriteLine("6 - Minutos: " + d1.Minute );
            Console.WriteLine("7 - Segundo: "+ d1.Second);
            Console.WriteLine("8 - Milisegundos: "+d1.Millisecond);
            Console.WriteLine("9 - Dia, Mes e ano: "+ d1.Day+"/"+d1.Month+"/"+d1.Year);
            Console.WriteLine("10 -DateTime definido por TimeOfDay "+ d1.TimeOfDay);
            Console.WriteLine("11 - Ticks: "+ d1.Ticks);
            Console.WriteLine("12 - Data longa: "+ d1.ToLongDateString());
            Console.WriteLine("13 - Horario: "+ d1.ToLongTimeString());
            Console.WriteLine("14 - Data padrão Americano: " + d1.ToShortDateString());
            Console.WriteLine("15 - Horario sem segundos: "+ d1.ToShortTimeString());
            Console.WriteLine("Data com máscara definida por ano, mês e dia usando ToString: "+ d1.ToString("yyyy/MM/dd"));

            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("Operações com DateTime");
            Console.WriteLine("______________________________________________________________________________");

            DateTime d2 = d1.AddHours(2);
            Console.WriteLine("DateTime d1 add mais 2 horas: "+d2);

            DateTime d3 = d1.AddMinutes(10);
            Console.WriteLine("DateTime d1 add mais 10 minutos: " + d3);

            DateTime d4 = d1.AddDays(07);
            Console.WriteLine("DateTime d1 add mais 07 dias: " + d4);

            TimeSpan d5 = d2.Subtract(d1);

            Console.WriteLine("Diferença de tempo entre d2 e d1: "+ d5);



        }
    }
}
