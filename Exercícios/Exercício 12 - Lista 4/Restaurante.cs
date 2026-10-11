using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_12___Lista_4
{
    internal class Restaurante
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public int Pessoas { get; set; }
        public double Preco { get; set; }

        public Restaurante(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Pessoas = 1;
        }

        public Restaurante(int numero, string nome, int pessoas) : this(numero, nome)
        {
            Pessoas = pessoas;
        }

        public void Adicao(double valor, int quantidade)
        {
            Preco += (valor * quantidade);
        }

        public void Cancelamento(double valor, int quantidade)
        {
            if (valor > Preco)
            {
                Console.WriteLine("Cancelamento Recusado.");
            }
            else
            {
                Preco -= (valor * quantidade);
            }
        }

        public override string ToString()
        {
            return $"Mesa {Numero}, Cliente: {Nome}, Pessoas: {Pessoas}, Consumo: R$ {Preco:F2}";
        }
    }
}