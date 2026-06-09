using System;

class Program
{
    static void Main()
    {
        const int TAMANHO = 10;
        int[] numeros = new int[TAMANHO];
        int numeroPesquisa;
        int ocorrencias = 0;

        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < TAMANHO; i++)
        {
            Console.Write($"Posição [{i}]: ");

            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nDigite o número que deseja pesquisar no vetor: ");
        numeroPesquisa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Resultados da Pesquisa ---");


        for (int i = 0; i < TAMANHO; i++)
        {
            if (numeros[i] == numeroPesquisa)
            {
                Console.WriteLine($"Encontrado na posição (índice): {i}");
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.WriteLine($"Total de ocorrências detectadas: {ocorrencias}");
        }
        else
        {
            Console.WriteLine($"O número {numeroPesquisa} não foi encontrado no vetor.");
        }
    }
}