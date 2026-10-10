namespace Exercício_6___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o identificador: ");
            int identificador = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá vida inicial(s/n): ");
            string resposta = Console.ReadLine();

            Personagem personagem;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre a vida inicial: ");
                int vidaInicial = int.Parse(Console.ReadLine());
                personagem = new Personagem(identificador, nome, vidaInicial);
            }
            else if (resposta.ToLower() == "n")
            {
                personagem = new Personagem(identificador, nome);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();

            Console.WriteLine(personagem);

            while (true)
            {
                Console.Write("\nEntre o valor do dano: ");
                int dano = int.Parse(Console.ReadLine());
                personagem.Dano(dano);
                Console.WriteLine(personagem);
                Console.Write("\nEntre o valor da cura: ");
                int cura = int.Parse(Console.ReadLine());
                personagem.Cura(cura);
                Console.WriteLine(personagem);
            }
        }
    }
}