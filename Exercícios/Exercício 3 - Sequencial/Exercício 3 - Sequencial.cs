namespace Exercício_3___Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número inteiro:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número inteiro:");
            int D = int.Parse(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
