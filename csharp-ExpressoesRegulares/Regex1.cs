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

<<<<<<< HEAD:csharp-ExpressoesRegulares/Regex1.cs
            string padrao = "[0-9][[0-9][[0-9][[0-9][-][0-9][0-9][0-9][0-9][0-9]";
            //[0-9] -> Caracteres de 0 a 9 -> Feito de acordo com os códigos da tabela ASCII
            //Cada cadeia de caracteres entre colchetes representa uma possibilidade entre os numeros, para condizer com o texto de texte, 4 possibilidades antes do hifen e 5 depois
            string textoDeTeste = "Meu número de telefone é 9748-28623";
=======
            string padrao = "[123456789][123456789][123456789][123456789][-][123456789][123456789][123456789][123456789][123456789]";
            //Cada cadeia de caracteres entre colchetes representa uma possibilidade entre os numeros, para condizer com o texto de teste, 4 possibilidades antes do hifen e 5 depois
            string textoDeTeste = "Meu nÃºmero de telefone Ã© 9748-28623";
>>>>>>> 4b461266a7a7748ab56aca99b5996ee07246edf1:csharp-ExpressoesRegulares/Program.cs

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();




        }
    }
}
