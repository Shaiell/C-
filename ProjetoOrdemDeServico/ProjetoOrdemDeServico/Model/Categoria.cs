using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public  int CategoriaId { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {

        }
    }

}
