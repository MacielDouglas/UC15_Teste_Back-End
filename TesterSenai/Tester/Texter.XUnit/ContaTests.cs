using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.Core;

namespace Texter.XUnit
{
    public class ContaTests
    {
        [Fact]
        public void Deposito_ComValor_AtualizaSaldo()
        {
            //Arrange
            double saldoInicial = 20;
            double valorDepositado = 4.55;
            double valorEsperado = 24.55;

            var conta = new Conta(saldoInicial); // Cria uma nova conta com o valor inicial

            //Act
            conta.Depositar(valorDepositado); // Deposita um valor

            //Assert
            //conta com um valor atualizado
            double valorAtualizado = conta.Saldo;
            // valorEsperado é de 24.55 soma do saldo inicail + valor depositado

            Assert.Equal(valorEsperado, valorAtualizado);

        }

        [Fact]
        public void Deposito_ComValorInvalido_RetornaErro()
        {
            //Arange
            double saldoInicial = 20;
            double valorDepositado = -8;

            var conta = new Conta(saldoInicial);

            //espera-se que ao depositar um valor invalido, retorne um erro
            Assert.Throws<ArgumentOutOfRangeException>(() => conta.Depositar(valorDepositado));
        }
    }
}
