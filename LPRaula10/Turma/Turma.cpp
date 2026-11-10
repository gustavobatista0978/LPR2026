using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula10
{
    class Matricula
    {
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public DateTime DataMatricula { get; set; }

        public Matricula(Aluno aluno, Turma turma)
        {
            Aluno = aluno;
            Turma = turma;
            DataMatricula = DateTime.Now;
        }
    }

    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Matricula> Matriculas { get; set; } = new List<Matricula>();

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public bool AdicionarMatricula(Turma turma)
        {
            // Verifica se já está matriculado nessa turma
            if (Matriculas.Any(m => m.Turma.Id == turma.Id))
            {
                Console.WriteLine($"{Nome} já está matriculado na turma {turma.Nome}.");
                return false;
            }

            var matricula = new Matricula(this, turma);
            Matriculas.Add(matricula);
            turma.Matriculas.Add(matricula);
            Console.WriteLine($"{Nome} matriculado com sucesso na turma {turma.Nome}.");
            return true;
        }
    }

    class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Matricula> Matriculas { get; set; } = new List<Matricula>();

        public Turma(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarMatricula(Aluno aluno)
        {
            aluno.AdicionarMatricula(this);
        }

        public List<Aluno> ListarAlunos()
        {
            return Matriculas.Select(m => m.Aluno).ToList();
        }

        public void MostrarAlunos()
        {
            Console.WriteLine($"\nAlunos da turma {Nome}:");
            var alunos = ListarAlunos();
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado.");
                return;
            }
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"- {aluno.Nome}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(1, "Ana");
            Aluno a2 = new Aluno(2, "Bruno");
            Aluno a3 = new Aluno(3, "Carla");

            Turma t1 = new Turma(101, "Programação Orientada a Objetos");
            Turma t2 = new Turma(102, "Banco de Dados");

            // Matriculando
            a1.AdicionarMatricula(t1);
            a1.AdicionarMatricula(t2);
            a2.AdicionarMatricula(t1);
            a3.AdicionarMatricula(t2);

            // Tentativa de matrícula duplicada
            a1.AdicionarMatricula(t1);

            // Listando alunos das turmas
            t1.MostrarAlunos();
            t2.MostrarAlunos();
        }
    }
}