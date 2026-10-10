using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_4___Lista_4
{
    internal class Estoque
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Estoque(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Estoque(int codigo, string nome, int quantidade) : this(codigo, nome)
        {
            Quantidade = quantidade;
        }

        public void Entrada(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void Saida(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Saída Recusada: Estoque insuficiente.");
            }
        }

        public override string ToString()
        {
            return $"Produto {Codigo}, {Nome}, Estoque: {Quantidade} unidades.";
        }
    }
}