using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.Model
{
    [Table("Pessoas")]
    public class  Pessoa
    {
        [Key]
        public int PessoaId { get; set;}
        public string Nome { get; set;}
        public string Cpf { get; set;}
        public string Telefone { get; set;}
        public DateTime CriadoEm { get; set;}
        public string Sexo { get; set;}
        

        public Pessoa()
        {

        }
    }
}
