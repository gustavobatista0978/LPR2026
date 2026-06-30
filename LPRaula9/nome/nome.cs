using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Quantos nomes deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine());

        List<string> nomes = new List<string>();

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            nomes.Add(Console.ReadLine());
        }

        int maiorQuantidade = 0;
        List<List<string>> grupos = new List<List<string>>();

        foreach (string nome in nomes)
        {
            int tamanho = nome.Length;

            while (grupos.Count <= tamanho)
            {
                grupos.Add(new List<string>());
            }

            grupos[tamanho].Add(nome);

            if (grupos[tamanho].Count > maiorQuantidade)
            {
                maiorQuantidade = grupos[tamanho].Count;
            }
        }

        Console.WriteLine("\nSaída:");

        for (int linha = 0; linha < maiorQuantidade; linha++)
        {
            for (int tamanho = 0; tamanho < grupos.Count; tamanho++)
            {
                if (linha < grupos[tamanho].Count)
                {
                    Console.Write(grupos[tamanho][linha] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}