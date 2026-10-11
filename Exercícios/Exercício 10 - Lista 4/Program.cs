namespace Exercício_10___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da linha: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá crédito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            Celular celular;

            if (resposta == "s".ToLower())
            {
                Console.Write("Entre o crédito inicial: ");
                double total = double.Parse(Console.ReadLine());
                celular = new Celular(numero, nome, total);
            }
using System;

namespace Exercício_10___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da linha: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá crédito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            Celular celular;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o crédito inicial: ");
                double total = double.Parse(Console.ReadLine());
                celular = new Celular(numero, nome, total);
            }
            else if (resposta.ToLower() == "n")
            {
                celular = new Celular(numero, nome);
            }
            else
            {
                // caso de entrada inválida — escolher comportamento padrão
                celular = new Celular(numero, nome);
            }

            Console.WriteLine(celular);
        }
    }
}
        }
    }
}