using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{

   
    class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;

        private int _proximaPosicao;

        public ListaDeContaCorrente()
        {
            _itens = new ContaCorrente[5];

            _proximaPosicao = 0;

        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Proxima posição: {_proximaPosicao}, número {item.Numero}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }

            _itens = novoArray;
        }



    }
}
