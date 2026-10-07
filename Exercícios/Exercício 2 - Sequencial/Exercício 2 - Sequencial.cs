namespace Exercício_2___Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do círculo:");
            double raio = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area:F4}");
        }
    }
}
