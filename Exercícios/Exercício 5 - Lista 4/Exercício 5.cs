namespace Exercício_5___Lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre a placa: ");
            string placa = Console.ReadLine();

            Console.Write("Entre o modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Haverá combustivel inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();

            Combustivel veiculo;

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre os litros iniciais: ");
                double tanque = double.Parse(Console.ReadLine());
                veiculo = new Combustivel(placa, modelo, tanque);
            }
            else if (resposta == "n" || resposta == "N")
            {
                veiculo = new Combustivel(placa, modelo);
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
                return;
            }

            Console.WriteLine("\nDados do veículo:\n" + veiculo);

            Console.Write("\nEntre os litros para abastecer: ");
            double litros = double.Parse(Console.ReadLine());
            veiculo.Abastecimento(litros);
            Console.Write("Dados do veículo atualizados:\n" + veiculo);

            Console.Write("\n\nEntre a distância da viagem em km: ");
            double distancia = double.Parse(Console.ReadLine());
            veiculo.Viagem(distancia);
            Console.Write("Dados do veículo atualizados:\n" + veiculo);
        }
    }
}
