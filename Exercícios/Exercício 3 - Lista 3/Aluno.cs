using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3___Lista_3
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            return NotaFinal() >= 60;
        }

        public double Faltam()
        {
            return 60 - NotaFinal();
        }
    }
}
