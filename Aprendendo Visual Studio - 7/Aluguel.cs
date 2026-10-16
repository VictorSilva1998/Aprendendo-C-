using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Visual_Studio___7
{
    internal class Aluguel
    {
        public string Nome;
        public string Email;
        public int Quarto;

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}