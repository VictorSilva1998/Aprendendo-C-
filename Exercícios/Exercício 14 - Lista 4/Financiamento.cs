using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_14___Lista_4
{
    internal class Financiamento
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Financiado { get; private set; }
        public double Entrada { get; set; }
        public double Devedor { get; private set; }

        public Financiamento(int numero, string nome, double financiado)
        {
            Numero = numero;
            Nome = nome;
            Financiado = financiado;
            Devedor = financiado;
        }

        public Financiamento(int numero, string nome,
            double financiado, double entrada)
            : this(numero, nome, financiado)
        {
            Entrada = entrada;
            Devedor = Financiado - entrada;
        }

        public void AplicarJuros()
        {
            Devedor *= 1.02;
        }

        public void Pagamentos(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Pagamento inválido.");
            }
            else if (valor > Devedor)
            {
                Console.WriteLine(
                    "Pagamento recusado: valor maior que o saldo devedor.");
            }
            else
            {
                Devedor -= valor;
            }
        }

        public override string ToString()
        {
            return $"Contrato {Numero}, Cliente: {Nome}, Valor: R$ {Financiado:F2}, Saldo devedor: R$ {Devedor:F2}";
        }
    }
}