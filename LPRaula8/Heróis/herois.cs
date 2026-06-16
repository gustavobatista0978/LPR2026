using System;

struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

struct Equipe
{
    public Heroi[] herois;
    public int quantidade;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static int totalHerois = 0;

    static Equipe equipe = new Equipe
    {
        herois = new Heroi[3],
        quantidade = 0
    };

    // Cadastro de herói
    static void cadastrarHeroi()
    {
        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite de heróis atingido!");
            return;
        }

        Heroi novoHeroi = new Heroi();

        Console.Write("Nome do herói: ");
        novoHeroi.nome = Console.ReadLine();

        Console.Write("Poder do herói: ");
        novoHeroi.poder = Console.ReadLine();

        Console.Write("Pontuação do herói: ");
        novoHeroi.pontuacao = int.Parse(Console.ReadLine());

        herois[totalHerois] = novoHeroi;
        totalHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    // Selecionar equipe
    static void selecionarEquipe()
    {
        if (totalHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis!");
            return;
        }

        Console.WriteLine("\nHeróis cadastrados:");

        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine($"{i} - {herois[i].nome} | Poder: {herois[i].poder} | Pontuação: {herois[i].pontuacao}");
        }

        equipe.quantidade = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nEscolha o índice do herói {i + 1}: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha >= 0 && escolha < totalHerois)
            {
                equipe.herois[i] = herois[escolha];
                equipe.quantidade++;
            }
            else
            {
                Console.WriteLine("Índice inválido!");
                i--;
            }
        }

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    // Calcular pontuação total
    static int calcularPontuacaoTotal()
    {
        int total = 0;

        for (int i = 0; i < equipe.quantidade; i++)
        {
            total += equipe.herois[i].pontuacao;
        }

        return total;
    }

    // Exibir equipe
    static void exibirEquipe()
    {
        if (equipe.quantidade == 0)
        {
            Console.WriteLine("Nenhuma equipe selecionada!");
            return;
        }

        Console.WriteLine("\n=== EQUIPE MARVEL ===");

        for (int i = 0; i < equipe.quantidade; i++)
        {
            Console.WriteLine($"Herói: {equipe.herois[i].nome}");
            Console.WriteLine($"Poder: {equipe.herois[i].poder}");
            Console.WriteLine($"Pontuação: {equipe.herois[i].pontuacao}");
            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"Pontuação Total da Equipe: {calcularPontuacaoTotal()}");
    }

    // Menu principal
    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU PRINCIPAL ===");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }
    static void Main(string[] args)
    {
        menuPrincipal();
    }
}