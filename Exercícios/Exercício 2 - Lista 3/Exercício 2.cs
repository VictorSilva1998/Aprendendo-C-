namespace Exercício_2___Lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nFuncionário: " + x);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            x.AumentarSalario(porcentagem);
            Console.WriteLine($"\nDados atualizados: " + x);
        }
    }
}