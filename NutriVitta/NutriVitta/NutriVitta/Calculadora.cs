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

        public static double Classificacao(double imc)
        {
            ImcResultado resultadoImc;

            if (imc < 18.5)
                resultadoImc = Categoria.AbaixoDoPeso;
            else if (imc <= 24.9)
                resultadoImc = Categoria.PesoNormal;
            else if (imc <= 29.9)
                resultadoImc = Categoria.Sobrepeso;
            else if (imc <= 34.9)
                resultadoImc = Categoria.ObesidadeGrauI;
            else if (imc <= 39.9)
                resultadoImc = Categoria.ObesidadeGrauII;
            else
                resultadoImc = Categoria.ObesidadeGrauIII;

            return resultadoImc;

        }
    }
}
