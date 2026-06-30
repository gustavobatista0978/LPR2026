using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Criação da lista para armazenar as notas
        List<double> notas = new List<double>();

        Console.WriteLine("--- Cadastro de Notas ---");

        // Loop para solicitar as 5 notas
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite a nota do {i}º aluno: ");
            
            // Tratamento simples para garantir que o usuário digite um número válido
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, insira um número.");
                i--; // Decrementa o índice para repetir a tentativa da mesma nota
            }
        }

        Console.WriteLine("\n--- Resultados ---");

        // 1. Exibir todas as notas cadastradas
        Console.WriteLine("Notas cadastradas: " + string.Join(" | ", notas));

        // 2. Exibir a maior nota
        double maiorNota = notas.Max();
        Console.WriteLine($"Maior nota: {maiorNota}");

        // 3. Exibir a menor nota
        double menorNota = notas.Min();
        Console.WriteLine($"Menor nota: {menorNota}");

        // 4. Exibir a média das notas
        double media = notas.Average();
        Console.WriteLine($"Média das notas: {media:F2}"); // :F2 limita a 2 casas decimais
    }
}