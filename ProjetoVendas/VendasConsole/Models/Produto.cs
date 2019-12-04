using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Produto
    {

        public String nome { get; set; }
        public Double preco { get; set; }
        public int quantidade { get; set; }

        public Produto() {

        }

        public override string ToString()
        {
            return ($"\nNome: {this.nome} \nPreço: {this.preco} \nQuantidade: {this.quantidade}");
        }
    }
}
