namespace Aprendendo_Visual_Studio___10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho da Matriz?");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal Principal:");

            for(int i = 0;i < n; i++)
            {
                Console.WriteLine(mat[i,i]);
            }

            int negativos = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }

            Console.WriteLine("Número(s) Negativo(s): " + negativos);
        }
    }
}