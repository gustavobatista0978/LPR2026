using System;
using System.Collections.Generic;

namespace SistemaLivraria
{
    public struct Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao, int quantidadeDisponivel)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            QuantidadeDisponivel = quantidadeDisponivel;
        }
    }

    class Program
    {
        static Dictionary<int, Livro> biblioteca = new Dictionary<int, Livro>();

        static void Main(string[] args)
        {
            string opcao = "";
            while (opcao != "0")
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Emprestar");
                Console.WriteLine("4. Relatorio");
                Console.WriteLine("0. Sair");
                Console.Write("Opcao: ");
                opcao = Console.ReadLine();

                if (opcao == "1") CadastrarLivro();
                else if (opcao == "2") BuscarLivro();
                else if (opcao == "3") EmprestarLivro();
                else if (opcao == "4") ExibirRelatorio();
            }
        }

        static void CadastrarLivro()
        {
            Console.Write("Codigo do livro: ");
            int codigo = int.Parse(Console.ReadLine());

            if (biblioteca.ContainsKey(codigo))
            {
                Console.WriteLine("Esse codigo ja existe!");
                return;
            }

            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            Livro novoLivro = new Livro(titulo, autor, ano, qtd);
            biblioteca.Add(codigo, novoLivro);
            Console.WriteLine("Livro cadastrado!");
        }

        static void BuscarLivro()
        {
            Console.Write("Codigo do livro para buscar: ");
            int codigo = int.Parse(Console.ReadLine());

            if (biblioteca.ContainsKey(codigo))
            {
                Livro livro = biblioteca[codigo];
                Console.WriteLine("Titulo: " + livro.Titulo);
                Console.WriteLine("Autor: " + livro.Autor);
                Console.WriteLine("Quantidade: " + livro.QuantidadeDisponivel);
            }
            else
            {
                Console.WriteLine("Livro nao encontrado!");
            }
        }

        static void EmprestarLivro()
        {
            Console.Write("Codigo do livro para emprestar: ");
            int codigo = int.Parse(Console.ReadLine());

            if (biblioteca.ContainsKey(codigo))
            {
                Livro livro = biblioteca[codigo];

                if (livro.QuantidadeDisponivel > 0)
                {
                    livro.QuantidadeDisponivel = livro.QuantidadeDisponivel - 1;
                    biblioteca[codigo] = livro;
                    Console.WriteLine("Emprestimo realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Nao ha estoque deste livro!");
                }
            }
            else
            {
                Console.WriteLine("Livro nao encontrado!");
            }
        }

        static void ExibirRelatorio()
        {
            Console.WriteLine("\n--- LISTA DE LIVROS ---");
            foreach (var item in biblioteca)
            {
                int codigo = item.Key;
                Livro livro = item.Value;
                Console.WriteLine("Codigo: " + codigo + " | Titulo: " + livro.Titulo + " | Qtd: " + livro.QuantidadeDisponivel);
            }
        }
    }
}