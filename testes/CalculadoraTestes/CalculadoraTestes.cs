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
    public void DeveSomar10com10ERetornar20()
    {
            // Arrange- Montar o cenário.
            int num1 = 10;
            int num2 = 10;

            //Act- Com o cenário pronto, fazer a chamada da ação somar.
            int resultado = _calc.Somar(num1, num2);

            //Assert - Validar se os passos acima tem o resultado esperado!
            Assert.Equal(20, resultado);
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
    [Fact]

    public void Inserir2ERetornarTrue(){
        //Arrange 

        int num = 2;

        //Act 
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.Equal(true, resultado);
    }
}