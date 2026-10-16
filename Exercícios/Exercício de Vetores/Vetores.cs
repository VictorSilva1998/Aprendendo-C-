using System.Globalization;

namespace Exercício_de_Vetores
{
    internal class Vetores
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                produtos[i] = new Produto();

                Console.Write("Nome do produto: ");
                produtos[i].Nome = Console.ReadLine();

                Console.Write("Preço do produto: ");
                produtos[i].Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                soma += produtos[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("\nPREÇO MÉDIO = " + media.ToString("F2"));
        }
    }
}