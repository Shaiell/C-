using BancoDeDados.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair;


                do
                {
                    
                    Console.Clear();
                    Console.WriteLine("PROJETO BANCO DE DADOS: " +
                   "\n1-Cadastrar Produto" +
                   "\n2-Listar Produtos" +
                   "\n3-Buscar produto por nome"+
                   "\n4-Buscar produto por parte do nome"+
                   "\n5-Remover Produtos de Vendedor" +
                   "\n6-Editar Produto" +
                   "\n0-Sair\n");
                     sair = Convert.ToInt32(Console.ReadLine());

                    switch (sair)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Saindo...\n");
                            break;
                        case 1:
                            ProdutoView.CadastrarProduto();
                            break;
                        case 2:
                            ProdutoView.ListarProdutos();
                            break;
                        case 3:
                            ProdutoView.BuscarProdutoPorNome();
                            break;
                        case 4:
                            ProdutoView.BuscarProdutosPorParteNome();
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Item escolhido invalido\n");
                            break;
                    }
                    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal.\n");
                    Console.ReadKey();
                    Console.Clear();

                } while ((sair != 0));

            
        }
    }
}
