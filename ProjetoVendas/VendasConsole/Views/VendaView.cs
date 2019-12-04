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
    class VendaView
    {
        

        public static void CadastrarVenda()
        {
            try { 
                Venda venda = new Venda();
                Cliente cliente = new Cliente();
                Vendedor vendedor = new Vendedor();
                Produto produto = new Produto();
                ItemVenda produtoVenda = new ItemVenda(produto);
                Console.Clear();
                Console.WriteLine("1-Registrar Venda\n");
                Console.WriteLine("Informe CPF do cliente");
                cliente.Cpf = Console.ReadLine();
                venda.Cliente = ClienteDAO.ProcurarCliente(cliente.Cpf);
                Console.WriteLine("Informe CPF do vendedor");
                vendedor.Cpf = Console.ReadLine();
                venda.Vendedor = VendedorDAO.ProcurarVendedor(vendedor.Cpf);

                do
                {
                    produto = new Produto();
                    produtoVenda = new ItemVenda(produto);
                    Console.Clear();
                    Console.WriteLine("Adicionar Produtos\n");

                    Console.WriteLine("Informe o nome do produto: ");
                    produto.nome = Console.ReadLine();
                    produto = ProdutoDAO.ProcurarProduto2(produto.nome);
                    Console.WriteLine("Informe a quantidade: ");
                    produtoVenda.Quantidade = Convert.ToInt32(Console.ReadLine());
                    venda.Produtos.Add(produtoVenda);
                   
                    Console.WriteLine("\nDeseja adicionar mais um produto: S/N\n");
                } while (Console.ReadLine().ToUpper().Equals("S"));



                VendaDAO.CadastrarVenda(venda);
                Console.Clear();
                Console.WriteLine("Venda Cadastrada");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public static void ListarVendas()
        {
            Console.Clear();
            Console.WriteLine("4-Listar Vendas\n");           
            List<Venda> vendas = VendaDAO.ListarVendas();

            if (!vendas.Any())
            {
                Console.WriteLine("Não há vendas realizadas.");
            }
            else
            {
                foreach (var vend in vendas)
                {
                    Console.WriteLine(vend);
                }
            }
        }
    }
}
