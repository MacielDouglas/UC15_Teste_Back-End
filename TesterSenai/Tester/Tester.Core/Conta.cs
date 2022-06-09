using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Core
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            //Valor errado, caso o deposito seja menor ou igual a zero
            if (valor <= 0)
            {
                throw new
                    ArgumentOutOfRangeException("Valos do depósito não pode ser menor ou igual a zero.");
            }
            Saldo += valor;
        }
    }
}
