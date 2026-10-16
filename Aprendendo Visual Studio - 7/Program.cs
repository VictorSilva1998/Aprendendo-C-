namespace Aprendendo_Visual_Studio___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] aluguel = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                aluguel[i] = new Aluguel();

                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write("Nome: ");
                aluguel[i].Nome = Console.ReadLine();

                Console.Write("Email: ");
                aluguel[i].Email = Console.ReadLine();

                Console.Write("Quarto: ");
                aluguel[i].Quarto = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nQuartos Ocupados: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(aluguel[i]);
            }
        }
    }
}