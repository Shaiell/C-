using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Medels;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class MenuView
    {
        public  void menu()
        {           
            int sair = new int();
            do
            {
                sair = retornoMenu();
                Console.Clear();
                switch (sair)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...\n");
                        break;
                    case 1:
                        ClienteView.cadastrarCliente();                            
                        break;
                    case 2:
                        ClienteView.listarCliente();
                        break;
                    case 3:
                        VendedorView.cadastrarVendedor();
                        break;
                    case 4:
                        VendedorView.listarVendedor();
                        break;
                    case 5:
                        ProdutoView.cadastrarProduto();
                        break;
                    case 6:
                        ProdutoView.listarProduto();
                        break;
                    case 7:
                        VendaView.CadastrarVenda();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("8-Listar Vendas\n");
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("9-Listar Vendas por Cliente\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Item escolhido invalido\n");
                        break;
                }
                Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal.\n");
                Console.ReadKey();
                Console.Clear();

            } while ((sair !=0));


            
        }

        public  int retornoMenu()
        {
            Console.WriteLine("Informe a Opção desejada: " +
               "\n1-Cadastro de Cliente" +
               "\n2-Listar Cliente" +
               "\n3-Cadastro de Vendedor" +
               "\n4-Listar Vendedores"+
               "\n5-Cadastrar Produto" +
               "\n6-Listar Produto" +
               "\n7-Registrar Venda" +
               "\n8-Listar Vendas" +
               "\n9-Listar Vendas por Cliente" +
               "\n0-Sair\n");
                 int sair = Convert.ToInt32(Console.ReadLine());

            return sair;
        }
        

    }
}
