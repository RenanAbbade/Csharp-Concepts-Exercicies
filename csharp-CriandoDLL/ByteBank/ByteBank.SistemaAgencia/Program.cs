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
            ContaCorrente conta1 = new ContaCorrente(111,11111);

            ContaCorrente conta2 = new ContaCorrente(222, 22222);

            ContaCorrente conta3 = new ContaCorrente(333, 33333);

            ListaDeContaCorrente ListaContas = new ListaDeContaCorrente();

            ListaContas.Adicionar(conta1);

            ListaContas.Adicionar(conta2);

            ListaContas.Adicionar(conta3);

            string[] vetor = new string[5];

            List<string> nomes = new List<string>();

            for(int i = 0; i< 10;i++)
            {
                nomes.Add("Albes");
            }

            nomes.Add("Caio");

            foreach (string name in nomes)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }
    }
}
