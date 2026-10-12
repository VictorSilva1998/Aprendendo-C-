namespace Exercício_1___Lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
            x = new Retangulo();

            Console.WriteLine("Dados do retângulo:");
            Console.Write("Largura: ");
            x.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            x.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área: " + x.Area());
            Console.WriteLine("Perímetro: " + x.Perimetro());
            Console.WriteLine("Diagonal: " + x.Diagonal());
        }
    }
}