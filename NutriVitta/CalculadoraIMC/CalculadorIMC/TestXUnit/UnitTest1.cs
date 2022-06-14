using CalculadorIMC;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalculadoraIMC()
        {
            //Arrange
            //Arrange - Prepara��o
            double primeiroNumero = 1.91; //altura
            double segundoNumero = 93; //peso 

            double resultadoMult = 3.64; //adicionar apenas os primeiros tres digitos do resultado da multiplica��o 3.6481
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
        [InlineData(2.05, 4.20, 137, 32.61)]
        [InlineData(1.77, 3.13, 92, 29.39)] 

        public void TestCalculadoraIMCLista(double primeiroNumero, double resultadoMult, double segundoNumero, double IMC)
        {
            //Act - A��o

            var resultado = IMCalcular.Calcular.multiplicar(primeiroNumero);

            // var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);
            var resultDivisao = IMCalcular.Calcular.dividir(segundoNumero, Math.Round(resultado, 2, MidpointRounding.ToZero));
            var classeImc = IMCalcular.Calcular.classificacao(Math.Round(resultDivisao, 2, MidpointRounding.ToZero));

            //Assert - Verifica��o
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(classeImc, 2, MidpointRounding.ToZero));
        }

        //TESTE DE ERROS
        // O programa n�o roda com caracteres 

        [Theory]
        [InlineData(1.688, 2.849344, 68, 23.865142)] // erro foi adicionado muitos numeros decimais com a matem�tica correta.
        [InlineData(1.51, 2.41, 41, 17.91)] // erro foi trocado alguns numeros de forma aleatoria
        [InlineData(-2.05, 4.20, 137, 32.61)] // adicionado um valor negativo
        [InlineData(1*77, 3.13, 93, 29.39)] // retirado caracteres, e adicionado sinal multiplica��o '*'
        [InlineData(-1.77, 3.1, 9*3, 29.39)] // retirado caracteres e numeros negativos 

        public void TesteERROSCalculadora(double primeiroNumero, double resultadoMult, double segundoNumero, double IMC)
        {
            //Act - A��o

            var resultado = IMCalcular.Calcular.multiplicar(primeiroNumero);

            // var resultDivisao = Calculadora.Divisao(resultado, segundoNumero);
            var resultDivisao = IMCalcular.Calcular.dividir(segundoNumero, Math.Round(resultado, 2, MidpointRounding.ToZero));
            var classeImc = IMCalcular.Calcular.classificacao(Math.Round(resultDivisao, 2, MidpointRounding.ToZero));

            //Assert - Verifica��o
            Assert.Equal(resultadoMult, Math.Round(resultado, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(resultDivisao, 2, MidpointRounding.ToZero));
            Assert.Equal(IMC, Math.Round(classeImc, 2, MidpointRounding.ToZero));
        }
    }
}