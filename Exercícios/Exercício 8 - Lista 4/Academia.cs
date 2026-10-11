using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_8___Lista_4
{
    internal class Academia
    {
        public int Matricula { get; private set; }
        public string Nome { get; set; }
        public double Creditos { get; set; }

        public Academia(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Academia(int matricula, string nome, double creditos) : this(matricula, nome)
        {
            Creditos = creditos;
        }

        public void Comprar(int valor)
        {
            Creditos += (valor * 1.1);
        }

        public void Aulas(int quantidade)
        {
            if (quantidade > Creditos)
            {
                Console.WriteLine("Uso recusado: créditos insuficientes.");
                return;
            }
            else
            {
                Creditos -= quantidade;
            }
        }

        public override string ToString()
        {
            return $"Matricula {Matricula}, Aluno: {Nome}, Creditos: {Creditos}";
        }
    }
}