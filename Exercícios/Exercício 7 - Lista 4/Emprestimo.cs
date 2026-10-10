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

        public Emprestimo(int codigo, string titulo)
        {
            Codigo = codigo;
            Titulo = titulo;
        }

        public Emprestimo(int codigo, string titulo, int total) : this(codigo, titulo)
        {
            Total = total;
        }
    }
}
