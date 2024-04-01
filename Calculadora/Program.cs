using System;

#pragma warning disable CA1050 // Declarar tipos em namespaces
public class CalculadoraPratica
#pragma warning restore CA1050 // Declarar tipos em namespaces
{
    public double Soma(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtracao(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divisao(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            throw new DivideByZeroException("Não é possível dividir por zero");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalculadoraPratica calculadora = new CalculadoraPratica();

        Console.WriteLine("Digite seu primeiro número");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu segundo número");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {calculadora.Soma(num1, num2)}");
        Console.WriteLine($"Subtração: {calculadora.Subtracao(num1, num2)}");
        Console.WriteLine($"Multiplicação: {calculadora.Multiplicacao(num1, num2)}");
        try
        {
            Console.WriteLine($"Divisão: {calculadora.Divisao(num1, num2)}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
