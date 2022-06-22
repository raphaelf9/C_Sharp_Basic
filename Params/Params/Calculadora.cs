using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Params
{
    class Calculadora
    {

        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Soma2(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Soma3(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        public static int Soma4(params int[] numeros)
        {
            int soma = 0;
            for(int i = 0; i< numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
