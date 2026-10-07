namespace Exercício_3___Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros separados por espaço (A e B): ");
            string[] valores = Console.ReadLine().Split();

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
