using System;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;

    public double Imposto()
    {
        if (SalarioBruto <= 2000.0)
        {
            return SalarioBruto * 0.10;
        }
        else if (SalarioBruto <= 3000.0)
        {
            return SalarioBruto * 0.15;
        }
        else
        {
            return SalarioBruto * 0.20;
        }
    }

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto();
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
    }

    public void MostrarDados()
    {
        Console.WriteLine(Nome + ", $ " + SalarioLiquido().ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.Write("Salário bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Funcionário: ");
        f.MostrarDados();

        Console.WriteLine();
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine());

        f.AumentarSalario(porcentagem);

        Console.WriteLine();
        Console.Write("Dados atualizados: ");
        f.MostrarDados();
    }
}