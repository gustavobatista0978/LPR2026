using System;

class Retangulo
{
    public double Altura;
    public double Largura;

    public double calcArea()
    {
        return Altura * Largura;
    }

    public double calcPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre com a altura e a largura do retângulo: ");
        r.Altura = double.Parse(Console.ReadLine());
        r.Largura = double.Parse(Console.ReadLine());

        double area = r.calcArea();
        double perimetro = r.calcPerimetro();

        Console.WriteLine("AREA = " + area.ToString("F2"));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2"));
    }
}