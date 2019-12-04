using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVendas.Model
{
    [Table("Produtos")]
    class Produto
    {

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int ProdutId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

       
    }
}
