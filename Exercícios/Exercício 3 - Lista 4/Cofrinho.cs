using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3___Lista_4
{
    internal class Cofrinho
    {
        public string Objetivo { get; set; }
        public double Meta { get; private set; }
        public double Saldo { get; private set; }

        public Cofrinho(string objetivo, double meta)
        {
            Objetivo = objetivo;
            Meta = meta;
        }

        public Cofrinho(string Objetivo, double Meta, double valorInicial) : this(Objetivo, Meta)
        {
            Deposito(valorInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Retirada(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= (valor + (valor * 0.02));
            }
            else
            {
                Console.WriteLine("Retirada Recusada: Saldo insuficiente.");
            }
        }

        public override string ToString()
        {
            return $"Cofrinho {Objetivo}, Meta: {Meta.ToString("F2")}, Saldo: {Saldo.ToString("F2")}, Faltam: {(Meta - Saldo).ToString("F2")}";
        }
    }
}