using System.Net;

namespace Exercício_12___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da mesa: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá número de pessoas (s/n)? ");
            string resposta = Console.ReadLine();

            Restaurante restaurante;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o número de pessoas: ");
                int pessoas = int.Parse(Console.ReadLine());
                restaurante = new Restaurante(numero, nome, pessoas);
            }
            else if (resposta.ToLower() == "n")
            {
                restaurante = new Restaurante(numero, nome);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();

            Console.WriteLine(restaurante);

            int x = 2;
            while (x > 0)
            {
                Console.Write("\nEntre o preço unitário do item: ");
                double valor = double.Parse(Console.ReadLine());
                Console.Write("Entre a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                restaurante.Adicao(valor, quantidade);
                Console.WriteLine(restaurante);
                x--;
            }

            Console.Write("\nEntre o preço unitário do item a cancelar: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.Write("Entre a quantidade a cancelar: ");
            int quantidade2 = int.Parse(Console.ReadLine());
            restaurante.Cancelamento(valor2, quantidade2);
            Console.WriteLine(restaurante);

            Console.WriteLine("\nFechamento da conta:");
            Console.WriteLine($"Serviço (10%): R$ {restaurante.Preco * 0.1:F2}");
            Console.WriteLine($"Total com serviço: {restaurante.Preco * 1.1:F2}");
            Console.WriteLine($"Valor por pessoa: R$ {(restaurante.Preco * 1.1) / restaurante.Pessoas:F2}");
        }
    }
}