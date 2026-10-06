namespace Exercício_4___Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            double salario = horas * valorHora;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
