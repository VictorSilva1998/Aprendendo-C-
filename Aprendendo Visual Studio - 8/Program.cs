namespace Aprendendo_Visual_Studio___8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números deseja informar? ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[quantidade];
            int[] vetor2 = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantidade; i++)
            {
                vetor2[i] = vetor1[i];
            }

            for (int i = 0; i < quantidade - 1; i++)
            {
                for (int j = 0; j < quantidade - 1 - i; j++)
                {
                    if (vetor2[j] > vetor2[j + 1])
                    {
                        int auxiliar = vetor2[j];
                        vetor2[j] = vetor2[j + 1];
                        vetor2[j + 1] = auxiliar;
                    }
                }
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(vetor2[i] + " ");
            }
        }
    }
}