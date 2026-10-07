namespace Exercício_2___Classes__Objetos_e_Atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine());

            double media = (a.Salario + b.Salario) / 2;

            Console.WriteLine("\nSalário médio: " + media.ToString("F2"));
        }
    }
}