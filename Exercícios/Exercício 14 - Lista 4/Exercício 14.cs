namespace Exercício_14___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número do contrato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Entre o valor financiado: ");
            double financiado = double.Parse(Console.ReadLine());

            Console.Write("Haverá entreda (s/n)? ");
            string resposta = Console.ReadLine();

            Financiamento financiamento;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o valor da entrada: ");
                double entrada = double.Parse(Console.ReadLine());
                financiamento = new Financiamento(numero, nome, financiado, entrada);
            }
            else if (resposta.ToLower() == "n")
            {
                financiamento = new Financiamento(numero, nome, financiado);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(financiamento);

            Console.WriteLine("\nPassagem de um mês: juros de 2% aplicados.");
            financiamento.AplicarJuros();
            Console.WriteLine(financiamento);

            int y = 2;
            while (y > 0)
            {
                Console.Write("\nEntre o valor de pagamento: ");
                double pagamento = double.Parse(Console.ReadLine());
                financiamento.Pagamentos(pagamento);
                Console.WriteLine(financiamento);
                y--;
            }
        }
    }
}