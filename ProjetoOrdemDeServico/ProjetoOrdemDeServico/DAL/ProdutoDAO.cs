using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class ProdutoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarProduto(Produto p)
        {
            if (BuscarProdutoPorDescrição(p)==null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Produto BuscarProdutoPorDescrição(Produto p)
        {
            return  ctx.Produtos.SingleOrDefault(x => x.Descricao.Equals(p.Descricao));
        }

        public static List<Produto> BuscarProdutosPorCategoria(int IdCategoria)
        {
            return ctx.Produtos.Include("Categoria").Where(x => x.Categoria.CategoriaId == IdCategoria).ToList();
        }

        public static Produto BuscarProdutoPorId(int id)
        {
            return ctx.Produtos.Find(id);
        }

        public static void AlterarProduto(Produto p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void ExcluirProduto(Produto p)
        {
            ctx.Entry(p).State = EntityState.Deleted;
            ctx.SaveChanges();
        }

    }
}
