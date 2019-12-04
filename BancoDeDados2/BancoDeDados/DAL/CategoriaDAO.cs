using BancoDeDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.DAL
{
    
    class CategoriaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Categoria BuscarCategoriaPorNome(Categoria c)
        {
           return ctx.Categorias.FirstOrDefault(x => x.Nome.Equals(c.Nome));
        }


    }
}
