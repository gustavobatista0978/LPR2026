using System;

namespace Aula10
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double NotaProva1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho { get; set; }

        public double Media()
        {
            return (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7.0;
        }

        public double Final()
        {
            double media = Media();
            if (media >= 60) return 0;
            return 60 - media;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Matrícula: ");
            aluno.Matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota Prova 1: ");
            aluno.NotaProva1 = double.Parse(Console.ReadLine());
            Console.Write("Nota Prova 2: ");
            aluno.NotaProva2 = double.Parse(Console.ReadLine());
            Console.Write("Nota Trabalho: ");
            aluno.NotaTrabalho = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nMédia final: {aluno.Media():F2}");

            double precisa = aluno.Final();
            if (precisa == 0)
                Console.WriteLine("Aluno aprovado. Não precisa de prova final.");
            else
                Console.WriteLine($"Precisa de {precisa:F2} na prova final.");
        }
    }
}