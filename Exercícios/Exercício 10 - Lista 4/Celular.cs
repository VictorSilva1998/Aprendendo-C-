using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_10___Lista_4
{
    internal class Celular
    {
        public string Numero { get; private set; }
        public string Nome { get; set; }
        public double Credito { get; set; }

        public Celular(string numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Celular(string numero, string nome, double credito) : this(numero, nome)
        {
            Credito = credito;
        }

        public void Recargas(double valor)
        {
            Credito += valor;
        }

        public void Ligacoes (double valor, int minutos)
        {
            if (minutos * 0.5 + 0.2 > Credito)
            {
                Console.WriteLine("Ligação recusada. Crédito insuficiente.");
                return;
            }
            else
            {
                Credito -= minutos * 0.5 + 0.2;
            }
        }

        public override string ToString()
        {
            return $"Linha {Numero}, Titular: {Nome}, Crédito: {Credito.ToString("F2")}";
        }
    }
}