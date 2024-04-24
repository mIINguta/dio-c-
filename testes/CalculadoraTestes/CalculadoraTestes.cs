using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImplementacao _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }
    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
            // Arrange- Montar o cenário.
            int num1 = 5;
            int num2 = 10;

            //Act- Com o cenário pronto, fazer a chamada da ação somar.
            int resultado = _calc.Somar(num1, num2);

            //Assert - Validar se os passos acima tem o resultado esperado!
            Assert.Equal(15, resultado);
    }
}