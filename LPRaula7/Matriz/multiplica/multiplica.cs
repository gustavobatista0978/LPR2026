using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] resultado = new int[3, 3];

        Console.WriteLine("Digite os valores da matriz A:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nDigite os valores da matriz B:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultado[i, j] = 0;

                for (int k = 0; k < 3; k++)
                {
                    resultado[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nResultado da multiplicação A * B:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultado[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}