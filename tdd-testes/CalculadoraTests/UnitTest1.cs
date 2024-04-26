namespace CalculadoraTests;
using Calculadora.Models;

public class UnitTest1
{
    Calculadora calc = new Calculadora();
    
    [Fact]
    public void Somar1Com2ERetornar3()
    {
        int num1 = 1;     
        int num2 = 2;
        var resultadoEsperado = 3;
        var resultado = calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);

    }

    [Theory]
    [InlineData(4, 3, 7)]

    public void SomarInlineData(int num1, int num2, int resultadoEsperado)
    {
        var resultado = calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);

    }
    [Theory]
    [InlineData(4, 2, 2)]

    public void SomarDividirInlineData(int num1, int num2, int resultadoEsperado)
    {
        var resultado = calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);

    }

    [Theory]
    [InlineData(4, 3, 12)]

    public void MultiplicarInlineData(int num1, int num2, int resultadoEsperado)
    {
        var resultado = calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);

    }
}