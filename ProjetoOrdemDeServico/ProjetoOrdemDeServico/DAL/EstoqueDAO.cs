using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class EstoqueDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarItemNoEstoque(Estoque e)
        {
            ctx.Estoques.Add(e);
            ctx.SaveChanges();
        }

        public static List<EstoqueEntrada> BuscarEstoquePorCategoria(int IdCategoria)
        {
            return ctx.Estoques.AsNoTracking().OfType<EstoqueEntrada>().Include(x => x.Produto).Include(prod =>prod.Produto.Categoria).Where(x => x.Produto.Categoria.CategoriaId == IdCategoria).OrderBy(x => x.DataEntrada).ToList();
                
        }

        public static Estoque BuscarEstoquePorIdProduto(int id)
        {
            return ctx.Estoques.Include("Produto").FirstOrDefault(x => x.Produto.ProdutoId.Equals(id));
        }

        public static List<EstoqueEntrada> BuscarEstoquePorCategoriaLote(Estoque e)
        {
            return ctx.Estoques.OfType<EstoqueEntrada>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).Where(x => x.Produto.Categoria.CategoriaId == e.Produto.Categoria.CategoriaId).Where(x=> x.Lote == e.Lote).Where(x => x.Produto.Descricao == e.Produto.Descricao).OrderBy(x => x.DataEntrada).ToList();

        }

        public static List<EstoqueSaida> BuscarTodaListaDeSaida()
        {
            return ctx.Estoques.OfType<EstoqueSaida>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).OrderByDescending(x => x.DataSaida).ToList();

        }

        public static List<EstoqueSaida> BuscarListaDeSaidaPorID(int id)
        {
            return ctx.Estoques.OfType<EstoqueSaida>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).Where(x => x.OrdemDeServico == id).OrderByDescending(x => x.DataSaida).ToList();


        }

        public static List<EstoqueEntrada> ListaResumidacadastro(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);
            if (estoquePorID.Count != 0)
            {
                estoqueUnicos.Add(estoquePorID[0]);
            }
            bool add = true;

            for (int i = 0; i < estoquePorID.Count; i++)
            {
                for (int j = 0; j < estoqueUnicos.Count; j++)
                {
                    if (estoquePorID[i].Produto.Descricao.Equals(estoqueUnicos[j].Produto.Descricao))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    estoqueUnicos.Add(estoquePorID[i]);
                }
                add = true;
            }
            return estoqueUnicos;
        }

        public static List<EstoqueEntrada> ListaResumida(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);
            if(estoquePorID.Count!=0) { 
                estoqueUnicos.Add(estoquePorID[0]);
            }
            bool add = true;

            for (int i = 0; i < estoquePorID.Count; i++)
            {
                for (int j = 0; j < estoqueUnicos.Count; j++)
                {
                    if (estoquePorID[i].Lote.Equals(estoqueUnicos[j].Lote))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    estoqueUnicos.Add(estoquePorID[i]);
                }
                add = true;
            }
            return estoqueUnicos;
        }

        public static List<EstoqueEntrada> ListaResumidaQuantidade(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoqueUnicos = ListaResumida(IdCategoria);
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);
           
            

            for (int i = 0; i < estoqueUnicos.Count; i++)
            {
                estoqueUnicos[i].Quantidade = 0;
                for (int j = 0; j < estoquePorID.Count; j++)
                {
                    if (estoqueUnicos[i].Lote.Equals(estoquePorID[j].Lote))
                    {
                        estoqueUnicos[i].Quantidade += 1;
                    }
                }
               
            }
            return estoqueUnicos;
        }

        public static Estoque BuscarEstoquePorID(int id)
        {
            return ctx.Estoques.Find(id);

        }

        public static void ExcluirEstoque(Estoque e)
        {
            ctx.Entry(e).State = EntityState.Deleted;
            ctx.SaveChanges();
        }

        public static void AlterarEstoque(EstoqueSaida e)
        {
            ctx.Entry(e).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
