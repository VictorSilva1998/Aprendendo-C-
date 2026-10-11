using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_13___Lista_4
{
    internal class Cinema
    {
        public int Numero { get; private set; }
        public int Capacidade { get; private set; }
        public string Filme { get; set; }
        public double Total { get; set; }
        public int Quantidade { get; set; }

        public Cinema(int numero, int capacidade)
        {
            Numero = numero;
            Capacidade = capacidade;
            Filme = "Sem Filme";
        }

        public Cinema(int numero, int capacidade, string filme) : this(numero, capacidade)
        {
            Filme = filme;
        }

        public bool VendaInteira(int quantidade)
        {
            if (quantidade + Quantidade > Capacidade)
            {
                Console.WriteLine("Venda recusada: capacidade excedida.");
                Console.WriteLine($"Sala {Numero}, Filme: {Filme}, Ocupação: {Quantidade}/{Capacidade}, Arrecadação: {Total:F2}");
                return false;
            }
            else
            {
                Total += 30 * quantidade;
                Quantidade += quantidade;
                return true;
            }
        }

        public bool VendaMeia(int quantidade)
        {
            if (quantidade + Quantidade > Capacidade)
            {
                Console.WriteLine("Venda recusada: capacidade excedida.");
                Console.WriteLine($"Sala {Numero}, Filme: {Filme}, Ocupação: {Quantidade}/{Capacidade}, Arrecadação: {Total:F2}");
                return false;
            }
            else
            {
                Total += 15 * quantidade;
                Quantidade += quantidade;
                return true;
            }
        }

        public bool CancelamentoInteira(int quantidade)
        {
            if (quantidade > Quantidade)
            {
                Console.WriteLine("Cancelamento recusado: não foram vendidos tantos ingressos.");
                Console.WriteLine($"Sala {Numero}, Filme: {Filme}, Ocupação: {Quantidade}/{Capacidade}, Arrecadação: {Total:F2}");
                return false;
            }
            else
            {
                Total -= 30 * quantidade * 0.8;
                Quantidade -= quantidade;
                return true;
            }
        }

        public bool CancelamentoMeia(int quantidade)
        {
            if (quantidade > Quantidade)
            {
                Console.WriteLine("Cancelamento recusado: não foram vendidos tantos ingressos.");
                Console.WriteLine($"Sala {Numero}, Filme: {Filme}, Ocupação: {Quantidade}/{Capacidade}, Arrecadação: {Total:F2}");
                return false;
            }
            else
            {
                Total -= 15 * quantidade * 0.8;
                Quantidade -= quantidade;
                return true;
            }
        }

        public override string ToString()
        {
            return $"Sala {Numero}, Filme: {Filme}, Ocupação: {Quantidade}/{Capacidade}, Arrecadação: {Total:F2}";
        }
    }
}