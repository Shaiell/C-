using BancoDeDados.DAL;
using BancoDeDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.View
{
    class ProdutoView
    {

        public static void CadastrarProduto()
        {
            
                Console.Clear();
                Produto produto = new Produto();
                Categoria c = new Categoria();
                Console.WriteLine("5-Cadastrar Produto\n");
                Console.WriteLine("Informe o nome do produto:");
                produto.Nome = Console.ReadLine();
                Console.WriteLine("Informe o preço do produto:");
                produto.Preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quantidade do produto:");
                produto.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a categoria do produto:");
                c.Nome = Console.ReadLine();
                c = CategoriaDAO.BuscarCategoriaPorNome(c);

            if (c!=null)
            {
                produto.Categoria = c;

                ProdutoDAO.CadastrarProduto(produto);
                Console.WriteLine("Produto Cadastrado.");
            }
            else
            {
                Console.WriteLine("Essa categoria não existe");
            }

                

            
        }

        public static void ListarProdutos()
        {
            List<Produto> produtos = ProdutoDAO.ListarProdutos();
            Console.Clear();
            Console.WriteLine("2-Listar Produtos\n");

           foreach (var prod in produtos)
                {
                    Console.WriteLine(prod);
                }
            
        }

        public static void BuscarProdutoPorNome()
        {
            Produto produto = new Produto();
            Console.Clear();
            Console.WriteLine("3-Buscar Produto por nome:\n");

            Console.WriteLine("Informe o nome do produto:");
            produto.Nome = Console.ReadLine();
            produto = ProdutoDAO.BuscarProdutoPorNome(produto);

            if (produto!=null)
            {
                Console.WriteLine(produto);
            }
            else
            {
                Console.WriteLine("Produto não existe");
            }

            
        }

        public static void BuscarProdutosPorParteNome()
        {

            Produto produto = new Produto();
            Console.Clear();
            Console.WriteLine("3-Buscar Produto por parte do nome:\n");

            Console.WriteLine("Informe o nome do produto:");
            produto.Nome = Console.ReadLine();

            foreach (Produto item in ProdutoDAO.BuscarProdutosPorParteNome(produto))
            {
                Console.WriteLine(item);
            }

        }
    }
}
