namespace Exercício_2___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número do cartão: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();

            ValeRefeicao vale;

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre o valor do crédito inicial: ");
                double creditoInicial = double.Parse(Console.ReadLine());

                vale = new ValeRefeicao(numero, nome, creditoInicial);
            }
            else if (resposta == "n" || resposta == "N")
            {
                vale = new ValeRefeicao(numero, nome);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nDados do cartão:\n" + vale);

            Console.Write("\nEntre o valor da recarga: ");
            double recarga = double.Parse(Console.ReadLine());

            vale.Recarga(recarga);

            Console.WriteLine("\nDados do cartão atualizados:\n" + vale);

            Console.Write("\nEntre o valor da compra: ");
            double compra = double.Parse(Console.ReadLine());

            vale.Compra(compra);

            Console.WriteLine("\nDados do cartão atualizados:\n" + vale);
        }
    }
}
