namespace Exercício_8___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre a matricula: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá créditos iniciais (s/n)? ");
            string resposta = Console.ReadLine();

            Academia academia;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre a quantidade de créditos: ");
                double creditosInicial = double.Parse(Console.ReadLine());
                academia = new Academia(matricula, nome, creditosInicial);
            }
            else if (resposta.ToLower() == "n")
            {
                academia = new Academia(matricula, nome);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();

            Console.WriteLine(academia);

            Console.Write("\nEntre a quantidade de créditos a comprar: ");
            int creditos = int.Parse(Console.ReadLine());
            academia.Comprar(creditos);
            Console.WriteLine(academia);

            Console.Write("\nEntre a quantidade de aulas a usar: ");
            int aulas = int.Parse(Console.ReadLine());
            academia.Aulas(aulas);
            Console.WriteLine(academia);
        }
    }
}