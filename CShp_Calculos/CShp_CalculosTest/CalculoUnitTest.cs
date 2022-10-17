using CShp_Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShp_CalculosTest {
    public class CalculoUnitTest {
        [Fact]
        public void SomarDouble() {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var resultadoEssperado = 6;

            //Act
            var soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(resultadoEssperado, soma);
        }
        [Fact]
        public void Subtracao_Double() {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var resultadoEsperado = -0.2;

            //Act
            var sub = Calculo.Subtrair(num1, num2);

            //Assert
            Assert.Equal(resultadoEsperado, sub, 1);
        }
        [Fact]
        public void MultiplicaDouble() {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var resultadoesperado = 8.99;

            //Act
            var multiplicacao = Calculo.Multiplicar(num1 , num2);

            //Assert
            Assert.Equal(resultadoesperado, multiplicacao);
        }
        [Fact]
        public void DivideDouble() {
            //Arrange
            var num1 = 2;
            var num2 = 0.5;
            var resultadoEsperado = 4;

            //Act
            var divisao = Calculo.Dividir(num1 , num2);

            //Assert
            Assert.Equal(resultadoEsperado, divisao);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, +1, int.MinValue + 1)]
        public void Somar_DoisNumerosRelativos(int num1, int num2, int valorEsperado) {
            //Act
            var resultado = Calculo.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
