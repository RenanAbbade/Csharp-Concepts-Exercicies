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

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

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

                

                //<Para calculo da moda>
                //Se o dicionario contiver o valor 
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
                //</Para calculo da moda>
            }

            //se o calculo for o desvio padrao
            double media = CalculoMedia(numeros, numeros.Count);

            DesvioPadrao desvioPadrao = new DesvioPadrao(numeros, media);

            //CalculaModa(numeros);

            //dictionary
            int c = 0;
            int valorMaior = 0;
            double moda = 0;
            
            foreach(KeyValuePair<double, int> item in dictionary)
            {
                if(c == 0)
                    valorMaior = item.Value;

                if (item.Value > valorMaior)
                {
                    valorMaior = item.Value;
                    moda = item.Key;
                }
 
                Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
                c++;
            }

            Console.WriteLine("Moda: "+moda);
            Console.WriteLine("Mediana: " + CalculaMediana(numeros));
            Console.WriteLine("Media: " + media);

            List<double> listaOrd = new List<double>()
            {
               2.25,2.55,2.55,2.55,2.75,2.75,2.95,2.95,2.95,2.95,3.15,3.15,3.15,3.15,3.15,3.35,3.35,3.35,3.35,3.35,3.35
            };

            listaOrd.Sort();
            Console.WriteLine("");
            foreach (double num in listaOrd)
            {
                Console.WriteLine(num);
            }
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

        public static double CalculaMediana(List<double> nums)
        {
            nums.Sort();

            if(nums.Count % 2 != 0)
            {
                int index = (int)nums.Count / 2;
                return nums[index];
            }
            else
            {
                double num1 =  nums[(nums.Count-1) / 2];
                double num2 =  nums[(nums.Count) / 2];
                double mediana = (num1 + num2) / 2;

                return mediana;
            }
        }

        public static double CalculaModa(List<double> nums)
        {
            var dicionarioDeArrays = nums.GroupBy(x => x).Where(g => g.Count() > 1)
                 .Select(g => g.Key)
                 .ToList();

            return 0;
        }

    }
}
