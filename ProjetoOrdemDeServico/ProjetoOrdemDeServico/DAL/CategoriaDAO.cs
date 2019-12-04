using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class CategoriaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        
        public static void CadastrarCategorias()
        {
            Categoria cate;
            if(BuscarCategorias().Count <=0)
            {
                
                List<Categoria> cat = new List<Categoria>();
                cate = new Categoria();
                cate.Nome = "Processador";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Placa Mãe";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Memoria";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Placa de Video";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "HD";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "SSD";
                cat.Add(cate);

                for (int i = 0; i < cat.Count; i++)
                {
                    ctx.Categorias.Add(cat[i]);
                    ctx.SaveChanges();
                }
            }

        }

        public static List<Categoria> BuscarCategorias()
        {
            return ctx.Categorias.ToList();
        }

        public static Categoria BuscarCategoriasPorID(int id)
        {
            return ctx.Categorias.Find(id);
        }
    }
}
