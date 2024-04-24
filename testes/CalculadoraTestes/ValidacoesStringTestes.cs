using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact] // para mostrar que é um test
        public void DeveContar5EmJesusERetorner5(){

            //Arrange
            string texto = "Jesus";
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);
            // Assert
            Assert.Equal(5, resultado);
        }
    }
}