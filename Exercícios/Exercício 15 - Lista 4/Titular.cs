using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_15___Lista_4
{
    internal class Titular
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Titular(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }

    internal class Conta
    {
        public int Numero { get; }
        public Titular Titular { get; private set; }
        public decimal Saldo { get; private set; }

        private decimal totalSacadoNoDia;
        private const decimal TaxaSaque = 5.00m;
        private const decimal LimiteDiario = 500.00m;

        public Conta(int numero, Titular titular,
            decimal depositoInicial = 0m)
        {
            Numero = numero;
            Titular = titular;
            Saldo = depositoInicial;
            totalSacadoNoDia = 0m;
        }

        public void TrocarTitular(Titular novoTitular)
        {
            if (novoTitular != null)
            {
                Titular = novoTitular;
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque invalido.");
                return false;
            }

            if (totalSacadoNoDia + valor > LimiteDiario)
            {
                Console.WriteLine(
                    "Saque recusado: limite diario excedido.");
                return false;
            }

            if (Saldo < valor + TaxaSaque)
            {
                Console.WriteLine(
                    "Saque recusado: saldo insuficiente.");
                return false;
            }

            Saldo -= valor + TaxaSaque;
            totalSacadoNoDia += valor;

            return true;
        }

        public void NovoDia()
        {
            totalSacadoNoDia = 0m;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular.Nome} ({Titular.Email}), Saldo: R$ {Saldo:F2}";
        }
    }
}