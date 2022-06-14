using NutriVitta;

namespace TestUnixCalcImc
{
    public class UnitTest1
    {
        [Fact]
        public void MultiplicacaoCalculadora()
        {
            //Arrange - Preparação
            double primeiroNumero = 1.91; //altura
            double segundoNumero = 93; //peso

            double resultadoMult = 3.64; //adicionar apenas os primeiros tres digitos do resultado da multiplicação
            double IMC = 25.54; // IMC = peso dividido pelo resultdoMult, apenas os tres primeiros digitos

            //Act - Ação
            var resultado = Calculadora.Multiplicacao(primeiroNumero);
            var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);
            var imcResultado = Calculadora.Classificacao(imcResultado);

            //Assert - Verificação
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            //Assert.AreEqual(29.71, resultDivisao);
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
        }

        [Theory]
        [InlineData(1.68, 2.82, 68, 24.11)]
        [InlineData(1.55, 2.40, 43, 17.91)]
        [InlineData(2.05, 4.20, 137, 32.61)]
        [InlineData(1.77, 3.13, 92, 29.39)]

        public void CalculadoraImcLista(double primeiroNumero, double resultadoMult, double segundoNumero, double IMC)
        {
            //Act - Ação
            var resultado = Calculadora.Multiplicacao(primeiroNumero);
            var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);

            //Assert - Verificação
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
        }

    }
}