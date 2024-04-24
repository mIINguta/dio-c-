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
            //Act- Com o cenário pronto, fazer a chamada da ação somar.
            //Assert - Validar se os passos acima tem o resultado esperado!
    }
}