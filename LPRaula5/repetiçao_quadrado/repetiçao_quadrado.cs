Console.WriteLine("Digite um número");
long numero = long.Parse(Console.ReadLine());
long quadrado = numero * (long)numero;
long soma = 0;
while (quadrado > 0)
{
long digito = quadrado % 10;
soma += digito;
quadrado /= 10;
}
Console.WriteLine("A soma dos digitos do quadrado é: " + soma);
