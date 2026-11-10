using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>()
        {
            { "Ana", 25 },
            { "Bruno", 42 },
            { "Carlos", 18 },
            { "Diana", 31 },
            { "Eduardo", 50 },
            { "Fernanda", 18 }
        };

        Console.WriteLine("--- Dicionário Inicial ---");
        ExibirDicionario(pessoas);
        Console.WriteLine();

        double mediaIdade = pessoas.Values.Average();
        Console.WriteLine($"Média de idade: {mediaIdade:F1}");
        Console.WriteLine("Pessoas com idade acima da média:");
        
        foreach (var par in pessoas)
        {
            if (par.Value > mediaIdade)
            {
                Console.WriteLine($"- {par.Key} ({par.Value} anos)");
            }
        }
        Console.WriteLine();

        int maiorIdade = pessoas.Values.Max();
        int menorIdade = pessoas.Values.Min();
        var maisVelhos = pessoas.Where(p => p.Value == maiorIdade).Select(p => p.Key);
        var maisNovos = pessoas.Where(p => p.Value == menorIdade).Select(p => p.Key);

        Console.WriteLine($"Mais velha(s) ({maiorIdade} anos): {string.Join(", ", maisVelhos)}");
        Console.WriteLine($"Mais nova(s) ({menorIdade} anos): {string.Join(", ", maisNovos)}");
        Console.WriteLine();

        Console.Write("Digite uma idade (Y) para remover do dicionário: ");
        if (int.TryParse(Console.ReadLine(), out int idadeY))
        {
            List<string> chavesParaRemover = pessoas.Where(p => p.Value == idadeY)
                                                   .Select(p => p.Key)
                                                   .ToList();

            if (chavesParaRemover.Count > 0)
            {
                foreach (string chave in chavesParaRemover)
                {
                    pessoas.Remove(chave);
                }
                Console.WriteLine($"\nSucesso: {chavesParaRemover.Count} pessoa(s) removida(s).");
            }
            else
            {
                Console.WriteLine($"\nNenhuma pessoa encontrada com {idadeY} anos.");
            }

            // Imprime o dicionário atualizado
            Console.WriteLine("\n--- Dicionário Atualizado ---");
            ExibirDicionario(pessoas);
        }
        else
        {
            Console.WriteLine("Valor inválido digitado.");
        }
    }
    static void ExibirDicionario(Dictionary<string, int> dicionario)
    {
        if (dicionario.Count == 0)
        {
            Console.WriteLine("O dicionário está vazio.");
            return;
        }

        foreach (var par in dicionario)
        {
            Console.WriteLine($"Nome: {par.Key} | Idade: {par.Value}");
        }
    }
}