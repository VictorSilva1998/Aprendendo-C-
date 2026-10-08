namespace Exercício_de_Fixação___Método_Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine());
            double valorPago = ConversorDeMoeda.ValorPago(quantidade);
            Console.WriteLine("Valor a ser pago em reais: " + valorPago.ToString("F2"));
        }
    }
}