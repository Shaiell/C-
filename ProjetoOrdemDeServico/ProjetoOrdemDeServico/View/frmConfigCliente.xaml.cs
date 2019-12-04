using ProjetoOrdemDeServico.DAL;
using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoOrdemDeServico.View
{
    /// <summary>
    /// Interaction logic for frmConfigCliente.xaml
    /// </summary>
    public partial class frmConfigCliente : Window
    {
        public frmConfigCliente()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Listar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pessoa cliente = (Cliente)dtaListaCliente.SelectedItem;

            if (cliente!=null)
            {
                frmAlterarUsuario frm = new frmAlterarUsuario(cliente);
                frm.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para alterar os dados");

            }

        }

        private void Listar()
        {
            List<Cliente> listaClientes = PessoaDAO.BuscarTodosCliente();
            dtaListaCliente.ItemsSource = listaClientes;
            dtaListaCliente.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pessoa cliente =(Pessoa)dtaListaCliente.SelectedItem;

            if (cliente !=null)
            {
                OrdemDeServico os = OrdemDeServicoDAO.listarOrdemPorCliente(cliente);

                if (os == null)
                {
                    PessoaDAO.ExcluirPessoa(cliente);
                    MessageBox.Show("Cliente Removido!");
                    Listar();
                }
                else
                {
                    MessageBox.Show("Não é possivel excluir o Cadastro, pois o cliente \nja fez uma solicitação de Ordem de serviço");
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }

            
        }
    }
}