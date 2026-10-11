namespace Exercício_10___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da linha: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá crédito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            Celular celular;

            if (resposta.ToLower() == "s".ToLower())
            {
                Console.Write("Entre o crédito inicial: ");
                double total = double.Parse(Console.ReadLine());
                celular = new Celular(numero, nome, total);
            }
            else if (resposta.ToLower() == "n".ToLower())
            {
                celular = new Celular(numero, nome);
            }
            else
            {
                celular = new Celular(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine(celular);

            Console.Write("\nEntre o valor da recarga: ");
            double valor = double.Parse(Console.ReadLine());
            celular.Recargas(valor);
            Console.WriteLine(celular);

            Console.Write("\nEntre a duração da ligação em minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            celular.Ligacoes(minutos);
            Console.WriteLine(celular);
        }
    }
}