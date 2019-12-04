using BancoDeDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.DAL
{
    class ProdutoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }

        public static List<Produto> ListarProdutos() => ctx.Produtos.Include("Categoria").ToList();

        public static Produto BuscarProdutoPorNome(Produto p)
        {
            //FirstOrDefault: é o metodo que retorna o primeiro objeto na busca.
            return ctx.Produtos.FirstOrDefault(x => x.Nome.Equals(p.Nome));

            //SingleOrDefault: é o metodo que retorna um unico objeto na busca.
            //return ctx.Produtos.SingleOrDefault(x => x.Nome.Equals(p.Nome));
        }

        public static Produto BuscarProdutoDatadeCriacao(DateTime d)
        {
            
            return ctx.Produtos.FirstOrDefault(x => x.CriadoEm.Day==d.Day && x.CriadoEm.Month == d.Month && x.CriadoEm.Year == d.Year);
        }
        public static List<Produto> BuscarProdutosPorParteNome(Produto p)
        {
            //Where: é o metodo que retorna uma lista de  objetos na buscas.
            return ctx.Produtos.Where(x => x.Nome.Contains(p.Nome)).ToList();

        }

        public static double CalcularValorDoEstoque()
        {
            return ctx.Produtos.Sum(x => x.Quantidade * x.Preco);
        }

        public void RemoverProduto(Produto p)
        {
            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
        }

        public void AlterarProduto(Produto p)
        {
            ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
