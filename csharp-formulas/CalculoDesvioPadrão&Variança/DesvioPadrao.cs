using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    public class DesvioPadrao
    {
        double Media;

        List<double> numerosDados = new List<double>();

        List<double> numerosDoDesvio = new List<double>();

        public DesvioPadrao(List<double> nums, double media)
        {
            Media = media;

            numerosDados.AddRange(nums);

            CalculoDesvio();

            Console.WriteLine("Resultado do desvio padrão: "+ DesviosAoQuadrado());
        }

        public void CalculoDesvio()
        {
            foreach (double num in numerosDados)
            {
                numerosDoDesvio.Add(num - Media);
            }
        }

        public double DesviosAoQuadrado()
        {
            double soma = 0;
            foreach (double num in numerosDoDesvio)
            {
                soma = soma + Math.Pow(num, 2);
            }

            double ResultadoParcial = soma / (numerosDados.Count - 1);

            return  Math.Sqrt(ResultadoParcial);

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
