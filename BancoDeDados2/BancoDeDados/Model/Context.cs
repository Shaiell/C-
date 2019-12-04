using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BancoDeDados.Model
{
    class Context : DbContext
    {

        //Nomear o arquivo do banco de dados.
        public Context() : base("DbProdutos"){}


        //Definir as Classe que iram virar tabela no Banco
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
