using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ProdutoView
    {

        public static void cadastrarProduto()
        {
            Console.Clear();
            try
            {
                Console.Clear();
                Produto produto = new Produto();
                Console.WriteLine("5-Cadastrar Produto\n");
                Console.WriteLine("Informe o nome do produto:");
                produto.nome = Console.ReadLine();
                Console.WriteLine("Informe o preço do produto:");
                produto.preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quantidade do produto:");
                produto.quantidade = Convert.ToInt32(Console.ReadLine());
                ProdutoDAO.cadastrarProduto(produto);
                Console.WriteLine("Produto Cadastrado.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void listarProduto()
        {
            List<Produto> produtos = ProdutoDAO.listarProduto();
            Console.Clear();
            Console.WriteLine("6-Listar Produtos\n");

            if (!produtos.Any())
            {
                Console.WriteLine("Não há Produtos cadastrados.");
            }
            else
            {
                foreach (var prod in produtos)
                {
                    Console.WriteLine(prod);
                }
            }
        }

    }
}
