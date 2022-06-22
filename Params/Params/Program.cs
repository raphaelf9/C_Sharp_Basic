using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma4(20, 30, 40, 50, 60, 70);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


        }
    }
}
