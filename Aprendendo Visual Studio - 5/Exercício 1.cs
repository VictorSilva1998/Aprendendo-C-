using System.Globalization;

namespace Aprendendo_Visual_Studio___5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();

            ContaBancaria conta;

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else if (resposta == "n" || resposta == "N")
            {
                conta = new ContaBancaria(numero, titular);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nDados da conta:\n" + conta);

            Console.Write("\nDigite o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            conta.Deposito(deposito);

            Console.WriteLine("\nDados da conta atualizados:\n" + conta);

            Console.Write("\nDigite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            conta.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados:\n" + conta);
        }
    }
}