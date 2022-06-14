using CalculadorIMC;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalculadoraIMC()
        {
            //Arrange
            //Arrange - Preparação
            double primeiroNumero = 1.91; //altura
            double segundoNumero = 93; //peso 

            double resultadoMult = 3.64; //adicionar apenas os primeiros tres digitos do resultado da multiplicação 3.6481
            double IMC = 25.54; // IMC= peso dividido pelo resultdoMult, apenas os tres primeiros digitos


            //Act
            var resultado = IMCalcular.Calcular.multiplicar(primeiroNumero);

            var resultDivisao = IMCalcular.Calcular.dividir(segundoNumero, Math.Round(resultado, 2, MidpointRounding.ToZero));

            var classeImc = IMCalcular.Calcular.classificacao(Math.Round(resultDivisao, 2, MidpointRounding.ToZero));


            //Assert
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(classeImc, 2, MidpointRounding.ToZero));

        }

        [Theory]
        [InlineData(1.68, 2.82, 68, 24.11)]
        [InlineData(1.55, 2.40, 43, 17.91)]
        [InlineData(2.05, 4.20, 137, 32.62)] // este dara erro. O IMC correto é 32.61
        [InlineData(1.77, 3.13, 92, 29.39)] 

        public void TestCalculadoraIMCLista(double primeiroNumero, double resultadoMult, double segundoNumero, double IMC)
        {
            //Act - Ação

            var resultado = IMCalcular.Calcular.multiplicar(primeiroNumero);

            // var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);
            var resultDivisao = IMCalcular.Calcular.dividir(segundoNumero, Math.Round(resultado, 2, MidpointRounding.ToZero));
            var classeImc = IMCalcular.Calcular.classificacao(Math.Round(resultDivisao, 2, MidpointRounding.ToZero));

            //Assert - Verificação
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(classeImc, 2, MidpointRounding.ToZero));
        }
    }
}