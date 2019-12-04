using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class ItemVenda
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
        
        public double Preco { get; set; }

        public ItemVenda(Produto p)
        {
            this.Produto = p;
            this.Preco = p.preco;
        }
    }
}
