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
    /// Interaction logic for frmConfigFuncionario.xaml
    /// </summary>
    public partial class frmConfigFuncionario : Window
    {
        Pessoa Funcionario;
        public frmConfigFuncionario(Pessoa p)
        {
            InitializeComponent();
            Funcionario = p;
        }

        

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Listar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pessoa funcionario = (Funcionario)dtaListaFuncionario.SelectedItem;
            if (funcionario !=null)
            {
                frmAlterarUsuario frm = new frmAlterarUsuario(funcionario);
                frm.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("Selecione o funcionario que deseja alterar os dados.");

            }

        }

        private void Listar()
        {
            List<Funcionario> listaFuncionarios = PessoaDAO.BuscarTodosFuncionarios();
            dtaListaFuncionario.ItemsSource = listaFuncionarios;
            dtaListaFuncionario.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pessoa funcionario = (Pessoa)dtaListaFuncionario.SelectedItem;

           
            if (funcionario !=null)
            {
                OrdemDeServico os = OrdemDeServicoDAO.listarOrdemPorFuncionario(funcionario);
                if (os == null)
                {
                    PessoaDAO.ExcluirPessoa(funcionario);
                    MessageBox.Show("Funcionario Removido!");
                    if (funcionario.Cpf.Equals(this.Funcionario.Cpf))
                    {
                        this.Funcionario = null;
                        frmConfigFuncionario frm = new frmConfigFuncionario(Funcionario);
                        Close();
                    }
                    Listar();

                }
                else
                {
                    MessageBox.Show("Não é possivel excluir o Cadastro, pois o Funcionario \nja fez uma aprovação de ordem de serviço");
                }
            }
            else
            {
                MessageBox.Show("Selecione o funcionario que deseja excluir.");

            }

        }
    }
}
