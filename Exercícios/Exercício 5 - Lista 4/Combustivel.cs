using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_5___Lista_4
{
    internal class Combustivel
    {
        public string Placa { get; private set; }
        public string Modelo { get; set; }
        public double Tanque { get; set; }

        public Combustivel(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }

        public Combustivel(string placa, string modelo, double tanque) : this(placa, modelo)
        {
            Tanque = tanque;
        }

        public void Abastecimento(double quantidade)
        {
            if (Tanque + quantidade > 50)
            {
                Console.Write($"Capacidade excedida: {Tanque + quantidade - 50:F2} L não foram abastecidos.\n");
                Tanque += 50 - Tanque;
            }
            else
            {
                Tanque += quantidade;
            }
        }

        public void Viagem(double distancia)
        {
            double consumo = distancia / 10;
            if (consumo > Tanque)
            {
                Console.WriteLine("Viagem Recusada: Combustível insuficiente.");
            }
            else
            {
                Tanque -= consumo;
            }
        }

        public override string ToString()
        {
            return $"Veiculo {Placa}, Modelo: {Modelo}, Combustível: {Tanque.ToString("F2")} L";
        }
    }
}
