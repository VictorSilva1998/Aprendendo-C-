namespace Exercício_3___Lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x;
            x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");

            x.Nota1 = double.Parse(Console.ReadLine());
            x.Nota2 = double.Parse(Console.ReadLine());
            x.Nota3 = double.Parse(Console.ReadLine());

            double notaFinal = x.NotaFinal();

            Console.WriteLine($"NOTA FINAL = {notaFinal:F2}");

            if (x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {x.Faltam():F2} PONTOS");
            }
        }
    }
}
