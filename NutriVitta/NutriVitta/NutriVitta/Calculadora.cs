using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriVitta
{
    public static class Calculadora
    {
        public static double Multiplicacao(double primeiroNumero)
        {
            return (primeiroNumero * primeiroNumero);
        }

        public static double Divisao(double resultado, double segundoNumero)
        {
            return(segundoNumero / Math.Round(resultado, 2, MidpointRounding.ToZero));
        }
    }
}
