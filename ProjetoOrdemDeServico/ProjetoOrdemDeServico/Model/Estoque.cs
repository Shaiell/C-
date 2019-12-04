using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }
        public  Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateTime DataEntrada { get; set; }

        public Estoque()
        {
            
        }
    }
}
