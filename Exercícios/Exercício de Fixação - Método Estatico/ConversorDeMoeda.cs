using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação___Método_Estatico
{
    internal class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double ValorPago(double quantidade)
        {
            return quantidade * Cotacao * 1.06;
        }
    }
}