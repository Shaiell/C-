using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    class EstoqueSaida:Estoque
    {
        public DateTime DataSaida { get; set; }
        public int OrdemDeServico { get; set; }

        
        public EstoqueSaida()
        {
            this.DataSaida = DateTime.Now;
            
        }
    }
}
