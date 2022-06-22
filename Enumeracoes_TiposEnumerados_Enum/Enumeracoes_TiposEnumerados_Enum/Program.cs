using Enumeracoes_TiposEnumerados_Enum.Entities;
using Enumeracoes_TiposEnumerados_Enum.Entities.Enums;
using System;

namespace Enumeracoes_TiposEnumerados_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumerações são um tipo para especificar de forma literal um conjunto de constantes relacionadas
            //enum(palavra chave) é um tipo valor
            //Melhor semântica, código mais legível e auxiliado pelo compilador

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
