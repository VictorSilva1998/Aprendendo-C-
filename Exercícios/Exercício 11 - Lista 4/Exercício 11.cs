using System.Globalization;

namespace Exercício_11___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conta A");
            Console.Write("Entre o número da conta: ");
            int numeroA = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeA = Console.ReadLine();

            Console.Write("Informar saldo inicial e limite (s/n)? ");
            string respostaA = Console.ReadLine().ToLower();

            Banco bancoA;

            if (respostaA == "s")
            {
                Console.Write("Entre o saldo inicial: ");
                double saldoA = double.Parse(
                    Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Entre o limite do cheque especial: ");
                double limiteA = double.Parse(
                    Console.ReadLine(), CultureInfo.InvariantCulture);

                bancoA = new Banco(numeroA, nomeA, saldoA, limiteA);
            }
            else if (respostaA == "n")
            {
                bancoA = new Banco(numeroA, nomeA);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nConta B");
            Console.Write("Entre o número da conta: ");
            int numeroB = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeB = Console.ReadLine();

            Console.Write("Informar saldo inicial e limite (s/n)? ");
            string respostaB = Console.ReadLine().ToLower();

            Banco bancoB;

            if (respostaB == "s")
            {
                Console.Write("Entre o saldo inicial: ");
                double saldoB = double.Parse(
                    Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Entre o limite do cheque especial: ");
                double limiteB = double.Parse(
                    Console.ReadLine(), CultureInfo.InvariantCulture);

                bancoB = new Banco(numeroB, nomeB, saldoB, limiteB);
            }
            else if (respostaB == "n")
            {
                bancoB = new Banco(numeroB, nomeB);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();
            Console.Write("Entre o valor da transferência de A para B: ");
            double valorTransferencia = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture);

            bancoA.Transferencia(bancoB, valorTransferencia);

            Console.WriteLine();
            Console.WriteLine(bancoA);
            Console.WriteLine(bancoB);

            Console.WriteLine();
            Console.Write("Entre um valor para saque na conta A: ");
            double valorSaque = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture);

            bancoA.Saque(valorSaque);

            Console.WriteLine(bancoA);
        }
    }
}