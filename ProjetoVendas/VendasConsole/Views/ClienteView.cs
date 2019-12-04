using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class ClienteView
    {
        public static void cadastrarCliente()
        {
            
            try
            {
                Console.Clear();
                Console.WriteLine("1-Cadastro de Cliente\n");
                Cliente cliente = new Cliente();
                Console.WriteLine("Informe o nome do Cliente");
                cliente.Nome = (Console.ReadLine());
                Console.WriteLine("\nInforme o CPF do cliente");
                cliente.Cpf = (Console.ReadLine());

                if (Validacao.ValidarCpf(cliente.Cpf)) { 
                ClienteDAO.cadastrarCliente(cliente);
                Console.WriteLine("Cliente Cadastrado.");
                }
                else
                {
                    Console.WriteLine("CPF Invalido.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void listarCliente()
        {
            List<Cliente> clientes = ClienteDAO.listarClientes();
            Console.Clear();
            Console.WriteLine("2-Listar Clientes\n");

            if (!clientes.Any())
            {
                Console.WriteLine("Não há Clientes cadastrados.");
            }
            else
            {
                foreach (var clie in clientes)
                {
                    Console.WriteLine(clie);
                }
            }
        }

        

    }
}
