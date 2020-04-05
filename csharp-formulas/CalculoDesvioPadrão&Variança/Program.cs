using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo dos desvios padrões dos conjuntos amostrais!");

            List<double> numeros = new List<double>();
           
            bool insercao = true;

            while (insercao == true)
            {
                Console.WriteLine("Digite o proximo número da sequencia!");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number == 0)
                {
                    insercao = false;
                    break;
                }
                    
                numeros.Add(number);
             
            }


            double media = CalculoMedia(numeros, numeros.Count);

            List<double> numerosDoDesvio = new List<double>();

            numerosDoDesvio.AddRange(CalculoDesvio(numeros, media));

            int QuantidadeNums = numeros.Count;

            numeros.Clear();

            double somaDesviosAo2 = DesviosAoQuadrado(numerosDoDesvio);

            double ResultadoParcial = somaDesviosAo2 / (QuantidadeNums - 1);

            double ResultadoFinal = Math.Sqrt(ResultadoParcial);

            Console.WriteLine("Resultado Média " + media);
            Console.WriteLine("Soma desvios ao quadrado " + somaDesviosAo2);
            Console.WriteLine(": " + ResultadoParcial +"/"+ (QuantidadeNums-1));
            Console.WriteLine("Resultado Final " + ResultadoFinal);


        }

        public static double CalculoMedia(List<double> nums, int quantidadeNumeros)
        {
            double soma = 0;
            foreach(double num in nums)
            {
                soma = soma + num;
            }

            return soma / quantidadeNumeros;
        }


        public static List<double> CalculoDesvio(List<double> nums, double media)
        {
            List<double> ListaDosDesvios = new List<double>();

            foreach (double num in nums)
            {
                ListaDosDesvios.Add(num - media);
            }

            return ListaDosDesvios;
        }

        public static double DesviosAoQuadrado(List<double> nums)
        {
            double soma = 0;
            foreach (double num in nums)
            {
                soma = soma + Math.Pow(num, 2);
            }

            return soma;

        }
    }
}
