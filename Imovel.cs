using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerlist
{
     class Imovel
    {
        public string Endereco { get; set; }
        public  double Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public override string ToString()
        {
            string retorno = "Endereço: ";
            retorno += Endereco + "\n Preço: " + Preco + "\n Tipo: " + Tipo + "\n \n";
            return retorno;
        }
    }
}
