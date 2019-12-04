using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Medels;

namespace VendasConsole.Models
{
    class Venda
    {

        public Cliente Cliente { get; set; }

        public Vendedor Vendedor { get; set; }

        public List<ItemVenda> Produtos { get; set; }

        public DateTime Data {get;set; }

        public Venda()
        {
            this.Data = DateTime.Now;
            this.Cliente = new Cliente();
            this.Vendedor = new Vendedor();
            this.Produtos = new List<ItemVenda>();
        }
        
    }
}
