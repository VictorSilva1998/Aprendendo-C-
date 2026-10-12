namespace Exercício_15___Lista_4
{
    internal class Program
    {
        static decimal LerValor()
        {
            return decimal.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Entre o e-mail do titular: ");
            string email = Console.ReadLine();

            Titular titular = new Titular(nome, email);

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Havera deposito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            decimal depositoInicial = 0m;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o valor de deposito inicial: ");
                depositoInicial = LerValor();
            }

            Conta conta = new Conta(numero, titular, depositoInicial);

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            decimal saque = LerValor();

            conta.Sacar(saque);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            saque = LerValor();

            conta.Sacar(saque);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Novo dia.");

            conta.NovoDia();

            Console.Write("Entre um valor para saque: ");
            saque = LerValor();

            conta.Sacar(saque);
            Console.WriteLine(conta);
        }
    }
}