using System;

namespace FuncoesParaStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            //convertendo para maiusculo

            string maiusculo = original.ToUpper();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Maiusculo: " + maiusculo);

            string minusculo = original.ToLower();
            Console.WriteLine("Minusculo: " + minusculo);

            string esp = original.Trim(); //apaga todos os espaços
            Console.WriteLine("String original sem os espaços no final e no começo: -" + esp + "-");

            int n1 = original.IndexOf("bc");
            Console.WriteLine("Primeira ocorrência de bc: " + n1);

            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("Ultima ocorrencia de bc: " + n2);

            string cortado = original.Substring(3);
            Console.WriteLine("Substring 3: " + cortado);

            string cortado2 = original.Substring(3, 5);
            Console.WriteLine("Cortados 5 caracteres a partir da terceira posição: " + cortado2);

            string subst = original.Replace('a', 'x');
            Console.WriteLine("Substituidos os caracteres 'a' por caracteres 'x': " + subst);

            string subst2 = original.Replace("abc", "xyz");
            Console.WriteLine("Substituidos todos 'abc' por 'xyz': "+ subst2);

            //testando uma string vazia

            bool b1 = string.IsNullOrEmpty(original);

            if(b1 == true)
            {
                Console.WriteLine("A string original está vazia!");
            }
            else
            {
                Console.WriteLine("A string original não está vazia!");
            }

            //testa se a variável é nula ou somente espaço em branco
            bool b2 = string.IsNullOrWhiteSpace(original);

            if(b2 == true)
            {
                Console.WriteLine("Variável vazia ou com espaços em branco!");
            }
            else
            {
                Console.WriteLine("Variável não está vazia ou somente com espaços em branco!");
            }

        }
    }
}
