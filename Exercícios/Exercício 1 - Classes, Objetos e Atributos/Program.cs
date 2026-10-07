namespace Exercício_1___Classes__Objetos_e_Atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            b.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.nome}");
            }
            else if (b.idade > a.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {b.nome}");
            }
            else
            {
                Console.WriteLine("As duas pessoas têm a mesma idade.");
            }
        }
    }
}
