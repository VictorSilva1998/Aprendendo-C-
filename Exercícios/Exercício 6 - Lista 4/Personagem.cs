using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_6___Lista_4
{
    internal class Personagem
    {
        public int Identificador { get; private set; }
        public string Nome { get; set; }
        public int Vida { get; private set; }

        public Personagem(int identificador, string nome)
        {
            Identificador = identificador;
            Nome = nome;
            Vida = 100;
        }

        public Personagem(int identificador, string nome, int vidaInicial) : this(identificador, nome)
        {
            Vida = vidaInicial;
        }

        public void Dano(int valor)
        {
            Vida -= valor;
            if (Vida < 0)
            {
                Vida = 0;
            }
        }

        public void Cura(int valor)
        {
            if (Vida <= 0)
            {
                Vida = 0;
                Console.WriteLine("Cura Recusada. Personagem derrotado.");
                Environment.Exit(0);
                return;
            }
            else
            {
                Vida += valor;
                    if (Vida > 100)
                    {
                        Vida = 100;
                    }
            }
        }

        public override string ToString()
        {
            if (Vida == 0)
            {
                return $"Personagem {Identificador}, {Nome}, Vida: {Vida}/100 (DERROTADO)";
            }

            return $"Personagem {Identificador}, {Nome}, Vida: {Vida}/100";
        }
    }
}