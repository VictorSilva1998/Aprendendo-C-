namespace Exercício_3___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o objetivo: ");
            string objetivo = Console.ReadLine();

            Console.Write("Entre a meta: ");
            double meta = double.Parse(Console.ReadLine());

            Console.Write("Haverá valor inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();

            Cofrinho cofrinho;

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre o valor inicial: ");
                double valorInicial = double.Parse(Console.ReadLine());
                cofrinho = new Cofrinho(objetivo, meta, valorInicial);
            }
            else if (resposta == "n" || resposta == "N")
            {
                cofrinho = new Cofrinho(objetivo, meta);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nDados do cofrinho:\n" + cofrinho);

            Console.Write("\nEntre o valor do depósito: ");
            double Deposito = double.Parse(Console.ReadLine());
            cofrinho.Deposito(Deposito);
            Console.WriteLine("Dados do cofrinho atualizados:\n" + cofrinho);

            Console.Write("\nEntre o valor da retirada: ");
            double Retirada = double.Parse(Console.ReadLine());
            cofrinho.Retirada(Retirada);
            Console.WriteLine("Dados do cofrinho atualizados:\n" + cofrinho);
        }
    }
}