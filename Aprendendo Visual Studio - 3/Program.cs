namespace Aprendendo_Visual_Studio___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2"));
        }
    }
}