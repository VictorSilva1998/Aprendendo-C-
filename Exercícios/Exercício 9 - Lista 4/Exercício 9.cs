namespace Exercício_9___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o código da reserva: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do hóspede: ");
            string nome = Console.ReadLine();

            Console.Write("Entre o valor da diária: ");
            double diaria = double.Parse(Console.ReadLine());

            Console.Write("Haverá número de diárias (s/n): ");
            string resposta = Console.ReadLine();

            Hotel hotel;

            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o número de diárias: ");
                int numeroDeDiarias = int.Parse(Console.ReadLine());
                hotel = new Hotel(codigo, nome, diaria, numeroDeDiarias);
            }
            else if (resposta.ToLower() == "n")
            {
                hotel = new Hotel(codigo, nome, diaria);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(hotel);

            Console.Write("\nEntre o número de diárias a prorrogar: ");
            int prorrogacao = int.Parse(Console.ReadLine());
            hotel.Prorrogacao(prorrogacao);
hotel.Prorrogacao(prorrogacao);
Console.WriteLine(hotel);
        }
    }
}