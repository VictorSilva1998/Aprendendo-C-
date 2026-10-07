namespace Exercício_3___Classes__Objetos_e_Atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto x;
            x = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + x);

            Console.WriteLine("\nQuantos produtos deseja adicionar ao estoque?");
            int Adicionar = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(Adicionar);
            Console.WriteLine($"Dados do produto: " + x);

            Console.WriteLine("\nQuantos produtos deseja remover do estoque?");
            int Remover = int.Parse(Console.ReadLine());
            x.RemoverProdutos(Remover);
            Console.WriteLine($"Dados do produto: " + x);
        }
    }
}
