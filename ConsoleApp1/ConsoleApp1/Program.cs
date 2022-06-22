using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            int n1 = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n1; i++)
            {
                Console.WriteLine("Valor #" + i);
                int n2 = int.Parse(Console.ReadLine());
                soma += n2;
            }

            Console.WriteLine("Total da soma = " + soma);
        }
    }
}
