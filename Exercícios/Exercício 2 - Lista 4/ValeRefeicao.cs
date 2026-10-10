using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercício_2___Lista_4
{
    internal class ValeRefeicao
    {
        public int Numero { get; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ValeRefeicao(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ValeRefeicao(int numero, string nome, double creditoInicial) : this(numero, nome)
        {
            Recarga(creditoInicial);
        }

        public void Recarga(double valor)
        {
            Saldo += valor;
        }

        public void Compra(double valor)
        {
            Saldo -= valor + 1.50;
        }

        public override string ToString()
        {
            return $"Cartão: {Numero}, " +
                   $"Funcionário: {Nome}, " +
                   $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
