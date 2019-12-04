using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BancoDeDados.Model
{
    [Table("Produtos")]
    class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public Categoria Categoria{get;set;}

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        public override string ToString()
        {
            return ($"\nNome: {this.Nome} \nPreço: {this.Preco} \nQuantidade: {this.Quantidade} \nCategoria: {this.Categoria.Nome}");
        }
    }
}
