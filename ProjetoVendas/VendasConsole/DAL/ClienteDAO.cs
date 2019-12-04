using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        private ClienteDAO()
        {

        }

        public static void cadastrarCliente(Cliente cliente)
        {
            consolidacaoCpfCliente(cliente);
            clientes.Add(cliente);                            
        }

        public static List<Cliente> listarClientes()
        {
            return clientes;            
        }

        public static void consolidacaoCpfCliente(Cliente cliente)
        {
            foreach (var clie in clientes)
            {
                if (clie.Cpf.Equals(cliente.Cpf))
                {
                    throw new Exception("CPF já cadastrado.");
                }
            }

        }

        public static Cliente ProcurarCliente(String cpf)
        {
            if (clientes.Any())
            {
                foreach (var clie in clientes)
                {
                    if (clie.Cpf.Equals(cpf))
                    {
                        return clie;
                    }
                }
                throw new Exception("Cliente não cadastrado.");
            }
            else
            {
                throw new Exception("Não há Clientes cadastrados.");
            }
        }
    }
}
