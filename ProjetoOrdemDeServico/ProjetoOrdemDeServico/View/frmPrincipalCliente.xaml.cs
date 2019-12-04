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
    /// Interaction logic for frmPrincipalCliente.xaml
    /// </summary>
    public partial class frmPrincipalCliente : Window
    {
        private Pessoa Cliente;
        public frmPrincipalCliente(Pessoa c )
        {
            InitializeComponent();
            this.Cliente = c;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarOrdem frm = new frmCadastrarOrdem(Cliente);
            frm.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frmAlterarUsuario frm = new frmAlterarUsuario(this.Cliente);
            frm.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            OrdemDeServico os = OrdemDeServicoDAO.listarOrdemPorCliente(this.Cliente);

            if (os == null)
            {
                PessoaDAO.ExcluirPessoa(this.Cliente);
                MessageBox.Show("Cliente Removido!");
                Close();
            }
            else
            {
                MessageBox.Show("Não é possivel excluir o Cadastro, pois o Cliente \nja fez a solicitação de ordem de serviço");
            }
        }
    }
}
