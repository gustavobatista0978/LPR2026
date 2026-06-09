using System;

class Program
{
    static void Main()
    {
        string[] cidades = {
            "Vitória",
            "Belo Horizonte",
            "Rio de Janeiro",
            "São Paulo"
        };

        int[,] distancias =
        {
            { 0, 524, 521, 882 },
            { 524, 0, 434, 586 },
            { 521, 434, 0, 429 },
            { 882, 586, 429, 0 }
        };

        int origem, destino;

        do
        {
            Console.WriteLine("\nEscolha a cidade de origem:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            origem = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a cidade de destino:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            destino = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDistância entre {cidades[origem]} e {cidades[destino]}: {distancias[origem, destino]} km");

        } while (origem != destino);

        Console.WriteLine("\nPrograma encerrado!");
    }
}