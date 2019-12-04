using ProjetoOrdemDeServico.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    public class Cliente:Pessoa
    {

        public Cliente()
        {
            this.CriadoEm = DateTime.Now;
            
        }

    }
}
