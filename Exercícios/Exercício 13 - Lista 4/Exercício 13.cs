namespace Exercício_13___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da sala: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre a capacidade: ");
            int capacidade = int.Parse(Console.ReadLine());

            Console.Write("Haverá um filme em cartaz (s/n)? ");
            string resposta = Console.ReadLine();

            Cinema cinema;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o filme: ");
                string filme = Console.ReadLine();
                cinema = new Cinema(numero, capacidade, filme);
            }
            else if (resposta.ToLower() == "n")
            {
                cinema = new Cinema(numero, capacidade);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(cinema);

            Console.Write("\nEntre a quantidade de ingressos inteiros: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Entre a quantidade de meia-entradas: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            if (!cinema.VendaInteira(quantidade))
            {
                return;
            }

            if (!cinema.VendaMeia(quantidade2))
            {
                return;
            }

            Console.WriteLine(cinema);

            Console.Write("\nCancelamento de ingressos inteiros: ");
            int quantidade3 = int.Parse(Console.ReadLine());
            Console.Write("Cancelamento de meia-entradas: ");
            int quantidade4 = int.Parse(Console.ReadLine());

            if (!cinema.CancelamentoInteira(quantidade3))
            {
                return;
            }

            if (!cinema.CancelamentoMeia(quantidade4))
            {
                return;
            }

            Console.WriteLine(cinema);

            Console.Write("\nEntre o novo filme: ");
            string novoFilme = Console.ReadLine();
            
            if (cinema.Quantidade != 0)
            {
                Console.WriteLine("Troca recusada: a sala está ocupada.");
                return;
            }
            else
            {
                cinema = new Cinema(numero, capacidade, novoFilme);
                Console.WriteLine(cinema);
            }
        }
    }
}