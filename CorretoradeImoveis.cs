using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerlist
{
    class CorretoradeImoveis
    {

        private Imovel[] listaImoveis;
        private bool[] ListaAluguel;

        private static CorretoradeImoveis Corretora;

        public static CorretoradeImoveis GetCorretoradeImoveis() {
            if (Corretora==null)
            {
                Corretora = new CorretoradeImoveis();
               
            }
            return Corretora;
        }
        private CorretoradeImoveis(){
          listaImoveis = new Imovel[100];
            ListaAluguel = new bool[100];
            for (int i = 0; i < 100; i++)
            {
                ListaAluguel[i] = true;
            }
        }
        public bool InserirImovel(string endereco, double preco, string tipo) {
            Imovel imovel= new Imovel(endereco,preco,tipo);
            int i=0;
            while (i < 100 && listaImoveis[i]!=null)
            {
                i++;
            }
            if (i<=100)
            {
                listaImoveis[i]=imovel;
                return true;
            }
            return false;
        }
        public bool AlterarPreco(string endereco,double preco) {
            int i = 0;
            while (i < 100 && listaImoveis[i] != null && listaImoveis[i].Endereco != endereco)
            {
                i++;
            }
            if (i<=100&& listaImoveis[i] != null)
            {
                listaImoveis[i].Preco=preco;
                return true;
            }
            return false;
        }
        public void ListarImoveis() {
            Console.WriteLine("Listando todos os imoveis: ");
            for (int i = 0; i < 100 && listaImoveis[i] != null; i++)
            {
                Console.Write(listaImoveis[i]);
            }
            
        }
        public void ListarImoveisDisponiveis()
        {
            Console.WriteLine("Listando todos os imoveis disponíveis: ");
            for (int i = 0; i < 100 && listaImoveis[i] != null; i++)
            {
                if (ListaAluguel[i])
                {
                    Console.Write(listaImoveis[i]);
                }
                
            }

        }
        public void CalcularPrecoMedio()
        {
            double soma = 0;
            int i;
            for ( i = 0; i < 100 && listaImoveis[i] != null; i++)
            {
                soma += listaImoveis[i].Preco;
            }
            Console.WriteLine("Preço medio: "+ soma/i);
        }

    }
}
