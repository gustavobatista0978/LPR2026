        Random random = new Random();
        int numeroAleatorio = random.Next(0, 100);
        int tentativas = 0;
        int numero = -1; 

        Console.WriteLine("Adivinhe o numero aleatorio entre 0 e 100");

        while (numero != numeroAleatorio)
        {
            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            tentativas++;

            if (numero < numeroAleatorio)
            {
                Console.WriteLine("O numero é maior que " + numero);
            }
            else if (numero > numeroAleatorio)
            {
                Console.WriteLine("O numero é menor que " + numero);
            }
        }

        Console.WriteLine("Parabéns, você acertou o numero!");
        Console.WriteLine("O numero aleatorio era: " + numeroAleatorio);
        Console.WriteLine("Você precisou de " + tentativas + " tentativas para acertar o numero!");
   