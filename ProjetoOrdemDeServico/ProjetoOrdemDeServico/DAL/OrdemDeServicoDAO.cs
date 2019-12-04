using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class OrdemDeServicoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarOs(OrdemDeServico o)
        {
            ctx.OrdensDeServico.Add(o);
            ctx.SaveChanges();
        }

        public static OrdemDeServico listarOrdemPorCliente(Pessoa c) {

            return ctx.OrdensDeServico.FirstOrDefault(x => x.Cliente.Cpf.Equals(c.Cpf));

        }

        public static OrdemDeServico listarOrdemPorFuncionario(Pessoa f)
        {

            return ctx.OrdensDeServico.Include("Funcionario").FirstOrDefault(x => x.Funcionario.Cpf.Equals(f.Cpf));

        }

        public static List<OrdemDeServico> ListarTodasAsOrdens()
        {
            return ctx.OrdensDeServico.ToList();
        }

        public static List<OrdemDeServico> ListarOsALiberarPorPessoa(Pessoa c)
        {
            return ctx.OrdensDeServico.Where(x => x.Aprovado.Equals(false) && x.Cliente.Cpf == c.Cpf).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public static List<OrdemDeServico> ListarOsLiberadasPorPessoa(Pessoa c)
        {
            return ctx.OrdensDeServico.Where(x => x.Aprovado.Equals(true) && x.Cliente.Cpf == c.Cpf).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public static List<OrdemDeServico> ListarOsALiberarTodos()
        {
            return ctx.OrdensDeServico.Where(x => x.Aprovado.Equals(false)).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public static List<OrdemDeServico> ListarOsLiberadasTodos()
        {
            return ctx.OrdensDeServico.Where(x => x.Aprovado.Equals(true)).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public static void LiberarOrdemServico(OrdemDeServico o)
        {
            ctx.Entry(o).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
