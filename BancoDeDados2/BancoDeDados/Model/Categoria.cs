using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Model
{
    [Table("Categoria")]
    class Categoria
    {
        [Key]
        public int categoriaID { get; set; }

        public string Nome { get; set; }

        public List<Produto> produtos { get; set; }

        

    }
}
