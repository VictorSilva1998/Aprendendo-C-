using System.Globalization;

namespace Aprendendo_Visual_Studio___9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmpregado #" + (i + 1) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                while (funcionarios.Any(e => e.Id == id))
                {
                    Console.Write("Esse ID já existe. Digite outro ID: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salary));
            }

            Console.Write("\nDigite o ID do funcionário que vai receber aumento de salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarios.Find(e => e.Id == procurarId);

            if (funcionario == null)
            {
                Console.WriteLine("\nEsse ID não existe!");
            }
            else
            {
                Console.Write("\nDigite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                funcionario.AumentarSalario(porcentagem);
            }

            Console.WriteLine();
            Console.WriteLine("\nLista de funcionários atualizada:");

            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}