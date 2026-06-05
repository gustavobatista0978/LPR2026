using System;

class Program {

    static string h1, h2, h3, h4, h5;
    static string p1, p2, p3, p4, p5;
    static int pt1, pt2, pt3, pt4, pt5;
    static int pontosequipe = 0;
    
    static string equipe1, equipe2, equipe3;
    static string poder1, poder2, poder3;
    static int pontos1, pontos2, pontos3;
    
    static void Main(string[] args) 
    {
        Console.WriteLine("Bem-vindo ao programa de heróis!");
        Console.WriteLine("Aqui você pode criar e interagir com seus heróis favoritos.");

        menuprincipal();

        Console.WriteLine("\nProcesso finalizado. Obrigado por usar o programa de heróis!");
    }

    static void menuprincipal()
    {
        int opçao = -1;
        while (opçao != 0)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Cadastrar Heróis");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Calcular Pontos da Equipe");
            Console.WriteLine("4. Exibir Equipe Selecionada");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha: ");
            opçao = int.Parse(Console.ReadLine());

            if (opçao == 1)
            {
                cadastrarHerois();
            }
            else if (opçao == 2)
            {
                selecionarequipe();
            }
            else if (opçao == 3)
            {
                calcularPontos();
            }
            else if (opçao == 4)
            {
                exibirequipes();
            }
        }
    }

    static void cadastrarHerois()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\nCadastro do Herói {i}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Poder: ");
            string poder = Console.ReadLine();
            Console.Write("Pontuaçao: ");
            int pontos = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                h1 = nome; p1 = poder; pt1 = pontos;
            }
            else if (i == 2)
            {
                h2 = nome; p2 = poder; pt2 = pontos;
            }
            else if (i == 3)
            {
                h3 = nome; p3 = poder; pt3 = pontos;
            }
            else if (i == 4)
            {
                h4 = nome; p4 = poder; pt4 = pontos;
            }
            else if (i == 5)
            {
                h5 = nome; p5 = poder; pt5 = pontos;
            }
        }
    }

    static void selecionarequipe()
    {
        pontosequipe = 0;
        
        Console.WriteLine("\nSeleção de Equipe:");
        Console.WriteLine("1. " + h1 + " - Poder: " + p1 + " - Pontos: " + pt1);
        Console.WriteLine("2. " + h2 + " - Poder: " + p2 + " - Pontos: " + pt2);
        Console.WriteLine("3. " + h3 + " - Poder: " + p3 + " - Pontos: " + pt3);
        Console.WriteLine("4. " + h4 + " - Poder: " + p4 + " - Pontos: " + pt4); 
        Console.WriteLine("5. " + h5 + " - Poder: " + p5 + " - Pontos: " + pt5);
            
        Console.WriteLine("\nEscolha 3 heróis para sua equipe, pelo numero:");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Seleção do Herói {i}:");
            int escolha = int.Parse(Console.ReadLine());
            
            string nomeEsc = "";
            string poderEsc = "";
            int pontosEsc = 0;
            
            if (escolha == 1)
            {
                nomeEsc = h1; poderEsc = p1; pontosEsc = pt1;
            }
            else if (escolha == 2)
            {
                nomeEsc = h2; poderEsc = p2; pontosEsc = pt2;
            }
            else if (escolha == 3)
            {
                nomeEsc = h3; poderEsc = p3; pontosEsc = pt3;
            }
            else if (escolha == 4)
            {
                nomeEsc = h4; poderEsc = p4; pontosEsc = pt4;
            }
            else if (escolha == 5)
            {
                nomeEsc = h5; poderEsc = p5; pontosEsc = pt5;
            }
            else
            {
                Console.WriteLine("Seleção inválida. Tente novamente.");
                i--;
                continue;
            }

            if (i == 1) 
            { 
                equipe1 = nomeEsc; poder1 = poderEsc; pontos1 = pontosEsc; 
            }
            else if (i == 2) 
            { 
                equipe2 = nomeEsc; poder2 = poderEsc; pontos2 = pontosEsc; 
            }
            else if (i == 3) 
            { 
                equipe3 = nomeEsc; poder3 = poderEsc; pontos3 = pontosEsc; 
            }

            pontosequipe += pontosEsc;
            Console.WriteLine($"{nomeEsc} adicionado à equipe!");
        } 
    }

    static void calcularPontos()
    {
        Console.WriteLine($"\nTotal de pontos da equipe: {pontosequipe}");
    }

    static void exibirequipes()
    {
        Console.WriteLine("\nEquipe selecionada:");
        Console.WriteLine("Herói 1: " + equipe1 + " - Poder: " + poder1 + " - Pontos: " + pontos1);
        Console.WriteLine("Herói 2: " + equipe2 + " - Poder: " + poder2 + " - Pontos: " + pontos2);
        Console.WriteLine("Herói 3: " + equipe3 + " - Poder: " + poder3 + " - Pontos: " + pontos3);
    }
}