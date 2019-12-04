using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Cliente
    {



        #region C#

        public String Nome { get; set;}
        public String Cpf { get; set; }
        public DateTime Criadoem { get; set; }

        public Cliente()
        {
            this.Criadoem = DateTime.Now;

        }

        public override string ToString()
        {
            return ($"\nNome: {this.Nome} \nCPF: {this.Cpf} \nData de Cadastro: {this.Criadoem}");
        }

        public override bool Equals(Object obj)
        {
            Cliente obj1 = (Cliente)obj;
            if((this.Nome.Equals(obj1.Nome)) && (this.Cpf.Equals(obj1.Cpf))) { 
            return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Java
        //private String nome;
        //private String cpf;

        //public String getNome()
        //{
        //    return nome;
        //}

        //public void setNome(String nome)
        //{
        //    this.nome = nome;
        //}

        //public String getCpf()
        //{
        //    return cpf;
        //}

        //public void setCpf(String cpf)
        //{
        //    this.cpf = cpf;
        //} 
        #endregion

    }
}
