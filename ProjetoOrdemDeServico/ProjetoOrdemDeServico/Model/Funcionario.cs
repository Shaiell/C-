using ProjetoOrdemDeServico.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    class Funcionario:Pessoa
    {

        public Funcionario()
        {
            this.CriadoEm = DateTime.Now;
            
        }

    }
}
