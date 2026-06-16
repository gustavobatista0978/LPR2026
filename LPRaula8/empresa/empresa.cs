

using System;

namespace ControleChamados
{
    struct Chamado
    {
        public int Numero;
        public string Solicitante;
        public string Setor;
        public int Prioridade;
        public string Status;
        public string Descricao;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chamado[] chamados = new Chamado[10];
            int totalCadastrados = 0;
            int opcao;

            do
            {
                Console.WriteLine("\n--- SISTEMA DE CHAMADOS ---");
                Console.WriteLine("1. Cadastrar Chamado");
                Console.WriteLine("2. Listar Chamados");
                Console.WriteLine("3. Atualizar Status");
                Console.WriteLine("4. Exibir Estatísticas");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1: cadastrarChamado(chamados, ref totalCadastrados); break;
                    case 2: listarChamados(chamados, totalCadastrados); break;
                    case 3: atualizarStatus(chamados, totalCadastrados); break;
                    case 4: estatisticas(chamados, totalCadastrados); break;
                }
            } while (opcao != 5);
        }

        static void cadastrarChamado(Chamado[] lista, ref int total)
        {
            if (total >= 10) { Console.WriteLine("Limite de 10 chamados atingido!"); return; }

            lista[total].Numero = total + 1;
            Console.Write("Solicitante: "); lista[total].Solicitante = Console.ReadLine();
            Console.Write("Setor: "); lista[total].Setor = Console.ReadLine();
            Console.Write("Prioridade (1-Baixa, 2-Média, 3-Alta): "); 
            int.TryParse(Console.ReadLine(), out lista[total].Prioridade);
            Console.Write("Descrição: "); lista[total].Descricao = Console.ReadLine();
            lista[total].Status = "Aberto";
            total++;
            Console.WriteLine("Chamado cadastrado com número " + lista[total-1].Numero);
        }

        static void listarChamados(Chamado[] lista, int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nNº: {lista[i].Numero} | Status: {lista[i].Status} | Prioridade: {classificarPrioridade(lista[i].Prioridade)}");
                Console.WriteLine($"Solicitante: {lista[i].Solicitante} | Setor: {lista[i].Setor}");
                Console.WriteLine($"Desc: {lista[i].Descricao}");
            }
        }

        static string classificarPrioridade(int p)
        {
            return p switch { 1 => "Baixa", 2 => "Média", 3 => "Alta", _ => "Desconhecida" };
        }

        static void atualizarStatus(Chamado[] lista, int total)
        {
            Console.Write("Digite o número do chamado: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= total)
            {
                Console.WriteLine("Novo status (1-Em andamento, 2-Resolvido, 3-Cancelado): ");
                string[] opcoes = { "Em andamento", "Resolvido", "Cancelado" };
                int op = int.Parse(Console.ReadLine());
                if (op >= 1 && op <= 3) lista[num - 1].Status = opcoes[op - 1];
            }
        }

        static void estatisticas(Chamado[] lista, int total)
        {
            int aberto = 0, andamento = 0, resolvido = 0, cancelado = 0;
            for (int i = 0; i < total; i++)
            {
                if (lista[i].Status == "Aberto") aberto++;
                else if (lista[i].Status == "Em andamento") andamento++;
                else if (lista[i].Status == "Resolvido") resolvido++;
                else if (lista[i].Status == "Cancelado") cancelado++;
            }
            Console.WriteLine($"\nEstatísticas: Aberto: {aberto}, Em andamento: {andamento}, Resolvido: {resolvido}, Cancelado: {cancelado}");
        }
    }
}