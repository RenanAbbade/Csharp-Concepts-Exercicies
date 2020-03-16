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

            string padrao = "[123456789][123456789][123456789][123456789][-][123456789][123456789][123456789][123456789][123456789]";
            //Cada cadeia de caracteres entre colchetes representa uma possibilidade entre os numeros, para condizer com o texto de texte, 4 possibilidades antes do hifen e 5 depois
            string textoDeTeste = "Meu número de telefone é 9748-28623";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();




        }
    }
}
