using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usado em base de dados para definir tipos que podem vir a receber um valor mas não há obrigatoriedade de inserir
            double? x = null; // O tipo double passa a poder receber um valor nulo
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault()); //o metodo GetValueOrDefault() pega o valor da variável ou o valor padrão do tipo

            Console.WriteLine(x.HasValue); // apresenta true caso haja um valor definido
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é nulo");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nulo");
            }
        }
    }
}
