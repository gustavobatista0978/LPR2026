using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;

        Console.WriteLine("Digite os elementos da matriz 3x3:");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Matriz[{linha},{coluna}]: ");
                matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                soma += matriz[linha, coluna];
            }
        }

        Console.WriteLine("\nSAÍDA:");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(matriz[linha, coluna] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Soma = {soma}");
    }
}