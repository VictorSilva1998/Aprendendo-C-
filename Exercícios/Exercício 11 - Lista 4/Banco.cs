using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_11___Lista_4
{
    internal class Banco
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public double Limite { get; private set; }

        public Banco(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Banco(int numero, string nome, double saldo, double limite) : this(numero, nome)
        {
            Saldo = saldo;
            Limite = limite;
        }

        public void Deposito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido.");
                return;
            }

            Saldo += valor;
        }

        public void Saque(double valor)
        {
            double taxa = 5.00;

            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");
                return;
            }

            if (Saldo - valor - taxa < -Limite)
            {
                Console.WriteLine("Saque recusado: limite de cheque especial excedido.");
                return;
            }

            Saldo -= valor + taxa;
        }

        public void Transferencia(Banco destino, double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de transferência inválido.");
                return;
            }

            if (Saldo - valor < -Limite)
            {
                Console.WriteLine("Transferência recusada: limite de cheque especial excedido.");
                return;
            }

            Saldo -= valor;
            destino.Saldo += valor;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: R$ {Saldo:F2}, Limite: R$ {Limite:F2}";
        }
    }
}