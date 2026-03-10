Console.WriteLine("Informe seu número:");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O número de horas trabalhadas:");
int horastrabalhadas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O valor que recebe por hora:");
double valorhora = Convert.ToDouble(Console.ReadLine());

double salario = horastrabalhadas * valorhora;
Console.WriteLine($"O funcionário {numero} tem um salário de R$ {salario:F2}");