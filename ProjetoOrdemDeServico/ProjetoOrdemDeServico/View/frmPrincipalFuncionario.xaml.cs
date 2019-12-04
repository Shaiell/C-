using ProjetoOrdemDeServico.Model;
using ProjetoOrdemDeServico.View;
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
    /// Interaction logic for frmPrincipalFuncionario.xaml
    /// </summary>
    public partial class frmPrincipalFuncionario : Window
    {
        Pessoa Funcionario;
        public frmPrincipalFuncionario(Pessoa f)
        {
            InitializeComponent();
            this.Funcionario = f;
        }

        private void ListarProduto(object sender, RoutedEventArgs e)
        {
            frmListarProduto frmListarProduto = new frmListarProduto();
            frmListarProduto.ShowDialog();
        }

        private void CadastrarEstoque(object sender, RoutedEventArgs e)
        {
            frmCadastroEstoque frmCadastrarEstoque = new frmCadastroEstoque();
            frmCadastrarEstoque.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            frmConfigCliente frm = new frmConfigCliente();
            frm.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frmConfigFuncionario frm = new frmConfigFuncionario(Funcionario);
            frm.ShowDialog();
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            frmListarOSFuncionario frm = new frmListarOSFuncionario(Funcionario);
            frm.ShowDialog();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (Funcionario == null)
            {
                Close();
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frmListaEstoqueSaida frm = new frmListaEstoqueSaida();
            frm.ShowDialog();
        }
    }
}
