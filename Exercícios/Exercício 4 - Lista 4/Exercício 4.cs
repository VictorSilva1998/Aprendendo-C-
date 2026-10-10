namespace Exercício_4___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá quantidade inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();

            Estoque estoque;

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre a quantidade em estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                estoque = new Estoque(codigo, nome, quantidade);
            }
            else if (resposta == "n" || resposta == "N")
            {
                estoque = new Estoque(codigo, nome);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nDados do produto:\n" + estoque);

            Console.Write("\nEntre a quantidade de entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque.Entrada(entrada);
            Console.WriteLine("\nDados atualizados:\n" + estoque);

            Console.Write("\nEntre a quantidade de saída: ");
            int saida = int.Parse(Console.ReadLine());
            estoque.Saida(saida);
            Console.WriteLine("\nDados atualizados:\n" + estoque);
        }
    }
}