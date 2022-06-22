using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        //Construtor padrão declarado para permitir sua inicialização no programa principal
        public Produto()
        {

        }

        //Construtor com valores inicializados
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Usando properties
        public string Nome
        {
            get { return _nome; }
            set // se o valor de value for diferente de vazio e maior que um caractere, _nome recebe value
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
