using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ///     

            string padrao = "[0-9][[0-9][[0-9][[0-9][-][0-9][0-9][0-9][0-9][0-9]";
            //[0-9] -> Caracteres de 0 a 9 -> Feito de acordo com os c�digos da tabela ASCII
            //Cada cadeia de caracteres entre colchetes representa uma possibilidade entre os numeros, para condizer com o texto de texte, 4 possibilidades antes do hifen e 5 depois
            string textoDeTeste = "Meu n�mero de telefone � 9748-28623";

            string padraoNovo = "[0-9]{4}[-][0-9]{4}"; //quantificador {*}, relaciona as possibilidades do colchete como se estivesse multiplicando por ele

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();




        }
    }
}
