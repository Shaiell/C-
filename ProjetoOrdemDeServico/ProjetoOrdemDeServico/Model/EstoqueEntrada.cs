using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
     public class EstoqueEntrada:Estoque
    {
        public EstoqueEntrada()
        {
            this.DataEntrada = DateTime.Now;
        }

    }
}
