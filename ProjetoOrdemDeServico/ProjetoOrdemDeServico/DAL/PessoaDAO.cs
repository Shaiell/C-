using ProjetoOrdemDeServico.Model;
using ProjetoOrdemDeServico.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class PessoaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        #region Cliente

        /*metodo criado para efetuar o cadastro do cliente no banco de dados*/
        public static bool CadastrarCliente(Pessoa cliente)
        {
            if (BuscarClientePorCPF(cliente)==null)
            {
                ctx.Pessoas.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        /*metodo criado para efetuar a busca de um cliente especifico por cpf*/
        public static Pessoa BuscarClientePorCPF(Pessoa c)
        {
            return ctx.Pessoas.OfType<Cliente>().SingleOrDefault(x => x.Cpf.Equals(c.Cpf));
        }

        public static List<Cliente> BuscarTodosCliente()
        {
            return ctx.Pessoas.OfType<Cliente>().ToList();
        }

        #endregion

        #region Funcionario

        /*metodo criado para efetuar o cadastro do funcionario no banco de dados*/
        public static bool CadastrarFuncionario(Pessoa funcionario)
        {
            if (BuscarFuncionarioPorCPF(funcionario) == null)
            {
                ctx.Pessoas.Add(funcionario);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }


        /*metodo criado para efetuar a busca de um funcionario especifico por cpf*/
        public static Pessoa BuscarFuncionarioPorCPF(Pessoa f)
        {
            return ctx.Pessoas.OfType<Funcionario>().SingleOrDefault(x => x.Cpf.Equals(f.Cpf));
        }

        public static List<Funcionario> BuscarTodosFuncionarios()
        {
            return ctx.Pessoas.OfType<Funcionario>().ToList();
        }

        #endregion

        #region All

        public static void AlterarPessoa(Pessoa p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void ExcluirPessoa(Pessoa p)
        {
            ctx.Entry(p).State = EntityState.Deleted;
            ctx.SaveChanges();
        }

        

        #endregion
    }
}
