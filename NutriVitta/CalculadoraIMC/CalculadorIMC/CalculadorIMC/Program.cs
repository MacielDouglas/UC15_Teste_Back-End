using System;

namespace CalculadorIMC
{
    public static class IMCalcular
    {
        public static void Main(string[] args)
        {
            double total, altura, peso;
            Console.WriteLine("Calcular IMC");
            Console.Write("De quantas pessoas quer calcular?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}ª Pessoa: ");
                Console.WriteLine();
                Console.Write("Insira a altura (ex. 1,70): ");
                altura = double.Parse(Console.ReadLine());
                Console.Write("Insira o peso (ex. 65):  ");
                peso = double.Parse(Console.ReadLine());

              

                var totaltura = Calcular.multiplicar(altura);

                var pesot = Calcular.dividir(peso, totaltura);

                var final = Calcular.classificacao(pesot);
             

             
            }
        }

           public static class Calcular
            {
            
            public static double multiplicar(double x)
            {
                return x * x;
            }

            public static double dividir(double x, double y)
            {
                return x / y;
            }

            public static double classificacao (double x)
            {
                //   x = x;
                
                Console.WriteLine("IMC: " + x.ToString("F2"));

                if (x < 18.5)
                {
                    Console.WriteLine("Abaixo do Peso");
                }

                if (x >= 18.5 && x <= 24.9)
                {
                    Console.WriteLine("Peso normal");
                }
                if (x >= 25 && x <= 29.9)
                {
                    Console.WriteLine("Sobrepeso");
                }
                
                if (x >= 30 && x <= 34.9)
                {
                    Console.WriteLine("Obesidade Grau I");
                }
                        
                if (x >= 35.0 && x <= 39.9)
                {
                    Console.WriteLine("Obesidade Grau II");
                }
                        
                if (x >= 40)
                {
                    Console.WriteLine("Obesidade GrauIII");
                }
                        

                return x;
            }
             
           }
           
    }
}

