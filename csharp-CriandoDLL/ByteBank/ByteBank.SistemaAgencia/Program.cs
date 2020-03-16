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

            
            //string padraoNovo = "[0-9]{4}-{0,1}[0-9]{4,5}"; //Caso de ter numeros de celular e numeros de telefone fixo
            //celular = 9*** - *****  \ Tel. Fixo: ****-****
            //Quantificador 

            string padraoNovo = "[0-9]{4}-?[0-9]{4,5}";//? = coringa no hifen
            string textoDeTeste = "Meu número de telefone é 9748-28623";

            string textoDeTeste2 = "Meu número de telefone fixo é 3748-2862";

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padraoNovo);

            Match resultado2 = Regex.Match(textoDeTeste2, padraoNovo);

            Console.WriteLine(resultado.Value);

            Console.WriteLine(resultado2.Value);


            Console.ReadLine();

        }
    }
}
