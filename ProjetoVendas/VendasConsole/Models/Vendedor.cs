using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Medels
{
    class Vendedor
    {

        #region C#

        public String Nome { get; set; }
        public String Cpf { get; set; }
        public DateTime Criadoem { get; set; }

        public Vendedor()
        {
            this.Criadoem = DateTime.Now;

        }

        public override string ToString()
        {
            return ($"\nNome: {this.Nome} \nCPF: {this.Cpf} \nData de Cadastro: {this.Criadoem}");
        }

        #endregion
    }
}
