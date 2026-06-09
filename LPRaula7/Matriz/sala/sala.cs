using System;

class Program
{
    // Função para verificar assento
    static string VerificarAssento(int[,] sala, int linha, int coluna)
    {
        if (sala[linha, coluna] == 0)
        {
            return "Livre";
        }
        else
        {
            return "Ocupado";
        }
    }

    static void Main()
    {
        int[,] sala = new int[6, 8]; // Todas começam com 0 (livre)
        int opcao;

        do
        {
            Console.WriteLine("\n===== CINEMA =====");
            Console.WriteLine("1 - Reservar assento");
            Console.WriteLine("2 - Cancelar reserva");
            Console.WriteLine("3 - Consultar assento");
            Console.WriteLine("4 - Mostrar mapa da sala");
            Console.WriteLine("5 - Encerrar");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Linha (0 a 5): ");
                    int linhaReserva = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    int colunaReserva = int.Parse(Console.ReadLine());

                    if (sala[linhaReserva, colunaReserva] == 0)
                    {
                        sala[linhaReserva, colunaReserva] = 1;
                        Console.WriteLine("Assento reservado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Assento já está ocupado!");
                    }
                    break;

                case 2:
                    Console.Write("Linha (0 a 5): ");
                    int linhaCancelar = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    int colunaCancelar = int.Parse(Console.ReadLine());

                    if (sala[linhaCancelar, colunaCancelar] == 1)
                    {
                        sala[linhaCancelar, colunaCancelar] = 0;
                        Console.WriteLine("Reserva cancelada!");
                    }
                    else
                    {
                        Console.WriteLine("Esse assento já está livre!");
                    }
                    break;

                case 3:
                    Console.Write("Linha (0 a 5): ");
                    int linhaConsulta = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    int colunaConsulta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Status do assento: " +
                        VerificarAssento(sala, linhaConsulta, colunaConsulta));
                    break;

                case 4:
                    Console.WriteLine("\nMAPA DA SALA");
                    Console.WriteLine("0 = Livre | 1 = Ocupado\n");

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write(sala[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    Console.WriteLine("Encerrando o sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }
}