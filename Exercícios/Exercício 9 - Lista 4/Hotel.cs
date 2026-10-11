using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_9___Lista_4
{
    internal class Hotel
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public double Diaria { get; set; }
        public int NumeroDeDiarias { get; set; }

        public Hotel (int codigo, string nome, double diaria)
        {
            Codigo = codigo;
            Nome = nome;
            Diaria = diaria;
            NumeroDeDiarias = 1;
        }

        public Hotel(int codigo, string nome, double diaria, int numeroDeDiarias) : this(codigo, nome, diaria)
        {
            NumeroDeDiarias = numeroDeDiarias;
        }

        public void Prorrogacao(int numeroDeDiarias)
        {
            if (NumeroDeDiarias + numeroDeDiarias > 30)
            {
                Console.WriteLine("Prorrogação recusada. Máximo de 30 diárias.");
                return;
            }
            else
            {
            NumeroDeDiarias += numeroDeDiarias;
            }
        }

        public override string ToString()
        {
            return $"Reserva {Codigo}, Hóspede: {Nome}, Diárias: {NumeroDeDiarias}, Total: {(Diaria * NumeroDeDiarias + 30).ToString("F2")}";
        }
    }
}