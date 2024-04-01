using Xunit;
using CalculadoraTests;



namespace CalculadoraTests;

public class CalculadoraTests
{
    private readonly CalculadoraTests _calculadora;

    public CalculadoraTests()
    {
        _calculadora = new CalculadoraTests();
    }

    [Fact]
    public void TestaSoma()
    {
        var resultado = _calculadora.Soma(5, 5);
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void TestaSubtracao()
    {
        var resultado = _calculadora.Subtracao(10, 5);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestaMultiplicacao()
    {
        var resultado = _calculadora.Multiplicacao(5, 5);
        Assert.Equal(25, resultado);
    }

    [Fact]
    public void TestaDivisao()
    {
        var resultado = _calculadora.Divisao(10, 2);
        Assert.Equal(5, resultado);
    }
}
