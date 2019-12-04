using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ProdutoDAO
    {

        private static List<Produto> produtos = new List<Produto>();

        public static void cadastrarProduto(Produto produto)
        {
            verificarNome(produto.nome);
            produtos.Add(produto);           
        }


        public static List<Produto> listarProduto()
        {
            return produtos;
        }

        public static void verificarNome(String produto)
        {
                foreach (var prod in produtos)
                {
                    if (prod.nome.Equals(produto))
                    {
                        throw new Exception("Produto já cadastrado.");
                    }
                }
        }

        public static Produto ProcurarProduto(String nome)
        {
            if (produtos.Any())
            {
                foreach (var prod in produtos)
                {
                    if (prod.nome.Equals(nome))
                    {
                        return prod;
                    }
                }
                throw new Exception("Produto já cadastrado.");
            }
            else
            {
                throw new Exception("Não há Produtos cadastrados.");
            }
        }

        public static Produto ProcurarProduto2(String nome)
        {
            if (produtos.Any())
            {
                foreach (var prod in produtos)
                {
                    if (prod.nome.Equals(nome))
                    {
                        return prod;
                    }
                }
                throw new Exception("Produto Não existe.");
            }
            else
            {
                throw new Exception("Não há Produtos cadastrados.");
            }
        }

    }
}
