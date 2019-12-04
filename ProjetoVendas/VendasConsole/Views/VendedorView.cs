using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Medels;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class VendedorView
    {

        public static void cadastrarVendedor()
        {
            
            try
            {
                Console.Clear();
                Console.WriteLine("1-Cadastro de Vendedor\n");
                Vendedor vendedor = new Vendedor();
                Console.WriteLine("Informe o nome do Vendedor");
                vendedor.Nome = (Console.ReadLine());
                Console.WriteLine("\nInforme o CPF do vendedor");
                vendedor.Cpf = (Console.ReadLine());
                if (Validacao.ValidarCpf(vendedor.Cpf))
                {
                    VendedorDAO.cadastrarVendedor(vendedor);
                    Console.WriteLine("Vendedor Cadastrado.");
                }
                else
                {
                    Console.WriteLine("Cpf Invalido.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void listarVendedor()
        {
            List<Vendedor> vendedores = VendedorDAO.listarVendedores();
            Console.Clear();
            Console.WriteLine("4-Listar Vendedores\n");

            if (!vendedores.Any())
            {
                Console.WriteLine("Não há Vendedores cadastrados.");
            }
            else
            {
                foreach (var vend in vendedores)
                {
                    Console.WriteLine(vend);
                }
            }
        }

    }
}
