using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_7___Lista_4
{
    internal class Emprestimo
    {
        public int Codigo { get; private set; }
        public string Titulo { get; set; }
        public int Total { get; private set; }
        public int Iniciais { get; private set; }
        public double Multas { get; private set; }

        public Emprestimo(int codigo, string titulo)
        {
            Codigo = codigo;
            Titulo = titulo;
            Total = 1;
            Iniciais = 1;
        }

        public Emprestimo(int codigo, string titulo, int total) : this(codigo, titulo)
        {
            Total = total;
            Iniciais = total;
        }

        public void Emprestar()
        {
            Total --;
        }

        public void Devolver(int dias)
        {
            Total ++;
            Multas = dias * 2;
        }

        public override string ToString()
        {
            if (Total == 0)
            {
                return "Empréstimo recusado: nenhum exemplar disponível";
            }

            return $"Livro {Codigo}, {Titulo}, Disponíveis: {Total}/{Iniciais}, Multas: R$ {Multas:F2}";
        }
    }
}