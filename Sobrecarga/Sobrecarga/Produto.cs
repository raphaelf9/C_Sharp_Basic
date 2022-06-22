
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor padrão declarado para permitir sua inicialização no programa principal
        public Produto()
        {

        }

        //Construtor com valores inicializados
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*//Construtor usando 'this' para pegar a quantidade vindo do construtor principal
        public Produto(string nome, double preco) : this ()
        {
            Nome = nome;
            Preco = preco;
        }*/

        //Construtor de sobrecarga com parâmetros diferentes

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

