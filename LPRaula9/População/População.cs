using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>()
        {
            { "São Paulo", 46000000 },
            { "Rio de Janeiro", 6730729 },
            { "Belo Horizonte", 2415872 },
            { "Salvador", 2564204 },
            { "Fortaleza", 2578483 },
            { "Brasília", 2996889 }
        };

        Console.WriteLine("--- Dicionário Inicial ---");
        ExibirDicionario(cidades);
        Console.WriteLine();

        double mediaPopulacao = cidades.Values.Average();
        Console.WriteLine($"Media populacional: {mediaPopulacao:N0} habitantes");
        Console.WriteLine("Cidades com população acima da media:");

        foreach (var par in cidades)
        {
            if (par.Value > mediaPopulacao)
            {
                Console.WriteLine($"- {par.Key} ({par.Value:N0} habitantes)");
            }
        }

        Console.WriteLine();

        int maiorPopulacao = cidades.Values.Max();
        int menorPopulacao = cidades.Values.Min();
        
        var maisPopulosas = cidades.Where(p => p.Value == maiorPopulacao).Select(p => p.Key);
        var menosPopulosas = cidades.Where(p => p.Value == menorPopulacao).Select(p => p.Key);

        Console.WriteLine($"Mais populosa(s) ({maiorPopulacao:N0} habitantes): {string.Join(", ", maisPopulosas)}");
        Console.WriteLine($"Menos populosa(s) ({menorPopulacao:N0} habitantes): {string.Join(", ", menosPopulosas)}");
    }

    static void ExibirDicionario(Dictionary<string, int> dicionario)
    {
        if (dicionario.Count == 0)
        {
            Console.WriteLine("Dicionário vazio.");
            return;
        }

        foreach (var par in dicionario)
        {
            Console.WriteLine($"{par.Key}: {par.Value:N0} habitantes");
        }
    }
}