namespace Exercício_7___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o código do livro: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Entre o título: ");
            string titulo = Console.ReadLine();

            Console.Write("Haverá mais de um exemplar? (s/n): ");
            char resposta = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Emprestimo emprestimo;

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o total de exemplares: ");
                int total = int.Parse(Console.ReadLine());
                emprestimo = new Emprestimo(codigo, titulo, total);
            }
            else if (resposta == 'n' || resposta == 'N')
            {
                emprestimo = new Emprestimo(codigo, titulo);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(emprestimo);

            int x = 2;
            while (x > 0)
            {
                Console.WriteLine("\nEmprestimo realizado.");
                emprestimo.Emprestar();
                Console.WriteLine(emprestimo);
                x--;
            }

            Console.Write("\nEntre os dias de atraso na devolução: ");
            int dias = int.Parse(Console.ReadLine());
            emprestimo.Devolver(dias);
            Console.WriteLine(emprestimo);
        }
    }
}