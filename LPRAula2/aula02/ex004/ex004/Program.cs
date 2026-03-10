Console.WriteLine("Digite o código da peça: ");
int codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de peças: ");
int quantidade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor unitário da peça: ");
double valorUnitario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o código da peça 2 :");
int codigo2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de peças da unidade 2: ");
int quantidade2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor unitário da peça 2: ");
double valorUnitario2 = Convert.ToDouble(Console.ReadLine());

double valorTotal = (quantidade * valorUnitario) + (quantidade2 * valorUnitario2);
Console.WriteLine($"Valor total a pagar: R$ {valorTotal:F2}");
