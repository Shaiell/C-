using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Medels;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {

        private static List<Vendedor> vendedores = new List<Vendedor>();

        private VendedorDAO()
        {

        }

        public static void cadastrarVendedor(Vendedor vendedor)
        {
            consolidacaoCpfVendedor(vendedor);
            vendedores.Add(vendedor);
        }

        public static List<Vendedor> listarVendedores()
        {
            return vendedores;
        }

        public static void consolidacaoCpfVendedor(Vendedor vendedor)
        {
            foreach (var vend in vendedores)
            {
                if (vend.Cpf.Equals(vendedor.Cpf))
                {
                    throw new Exception("CPF já cadastrado.");
                }
            }

        }

        public static Vendedor ProcurarVendedor(String cpf)
        {
            if (vendedores.Any())
            {
                foreach (var vend in vendedores)
                {
                    if (vend.Cpf.Equals(cpf))
                    {
                        return vend;
                    }
                }
                throw new Exception("Vendedor não cadastrado.");
            }
            else
            {
                throw new Exception("Não há Vendedores cadastrados.");
            }
        }
    }
}

