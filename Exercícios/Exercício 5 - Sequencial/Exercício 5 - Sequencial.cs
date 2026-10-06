namespace Exercício_5___Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da primeira peça (código, quantidade, valor) separados por espaço:");
            string[] peca1 = Console.ReadLine().Split();
            Console.WriteLine("Digite os dados da segunda peça (código, quantidade, valor) separados por espaço:");
            string[] peca2 = Console.ReadLine().Split();

            int codigo1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2]);

            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2]);

            double total = (quantidade1 * valor1) + (quantidade2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}
