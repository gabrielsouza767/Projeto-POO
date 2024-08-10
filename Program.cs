using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerlist
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.Title= "###Corretora de Imóveis###";
            int escolha = 0;
            string end;
            string tipo;
            double prec;
            CorretoradeImoveis corretoradeImoveis = CorretoradeImoveis.GetCorretoradeImoveis();
            do
            {
                Console.WriteLine("Corretora de Imóveis");
                Console.WriteLine("0 - sair");
                Console.WriteLine("1 - inserir imóvel");
                Console.WriteLine("2 - alterar preço");
                Console.WriteLine("3 - listar todos os imóveis");
                Console.WriteLine("4 - listar imóveis disponíveis");
                Console.WriteLine("5 - calcular valor médio");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.WriteLine("Digite o endereço: ");
                         end= Console.ReadLine();
                        Console.WriteLine("Digite o preço:");
                         prec=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o tipo do imóvel:");
                         tipo= Console.ReadLine();
                        Console.Clear();
                        if (corretoradeImoveis.InserirImovel(end, prec, tipo))
                        {
                            Console.WriteLine("Imóvel inserido com sucesso!");
                        }
                        else
                        {
                           Console.WriteLine("Ocorreu um erro ao inserir o imóvel");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o endereço do imóvel que deseja alterar:");
                        end=Console.ReadLine();
                        Console.WriteLine("Digite o novo valor:");
                        prec=Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        if (corretoradeImoveis.AlterarPreco(end, prec))
                        {
                            Console.WriteLine("Preço alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Imóvel não encontrado");
                        }
                        break;
                    case 3:
                        corretoradeImoveis.ListarImoveis();
                        break;
                    case 4:
                        corretoradeImoveis.ListarImoveisDisponiveis();
                        break;
                    case 5:
                        corretoradeImoveis.CalcularPrecoMedio();
                        break;
                    default: 
                        Console.WriteLine("Opção inválida...");
                        break;
                }
            } while (escolha!=0);
            Console.ReadKey();
        }
    }
}
