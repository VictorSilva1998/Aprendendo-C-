using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Visual_Studio___4
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
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
    }
}
