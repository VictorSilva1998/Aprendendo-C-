using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Visual_Studio___5
{
    internal class ContaBancaria
    {
        public int Numero { get; private set;}
        public string Titular {get; set;}
        public double Saldo {get; private set;}

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}\n" +
                   $"Titular: {Titular}\n" +
                   $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}