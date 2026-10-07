using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3___Classes__Objetos_e_Atributos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
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
            return Nome + " R$" + Preco.ToString("F2") + " Quantidade: " + Quantidade + "   Total: R$" + ValorTotalEmEstoque.ToString("F2");
        }
    }
}
