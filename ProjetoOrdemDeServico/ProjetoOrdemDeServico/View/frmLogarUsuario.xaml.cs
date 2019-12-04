using ProjetoOrdemDeServico.DAL;
using ProjetoOrdemDeServico.Model;
using ProjetoOrdemDeServico.Util;
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
    /// Interaction logic for frmLogarUsuario.xaml
    /// </summary>
    public partial class frmLogarUsuario : Window
    {
        public frmLogarUsuario()
        {
            InitializeComponent();
            txtCpf.Focus();
        }

        private void BtnLogarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (txtCpf.Text != "" && txtCpf.Text != null)
            {
                if (Helper.ValidarCpf(txtCpf.Text))
                {
                    if (Convert.ToBoolean(rdFuncionario.IsChecked))
                    {
                        Pessoa funcionario = new Funcionario();
                        funcionario.Cpf = txtCpf.Text;
                        funcionario = PessoaDAO.BuscarFuncionarioPorCPF(funcionario);
                        if(funcionario  !=null)
                        {
                            frmPrincipalFuncionario frmfuncionario = new frmPrincipalFuncionario(funcionario);
                            frmfuncionario.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Funcionario sem cadastrado ");
                            Limpar();
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(rdCliente.IsChecked))
                        {
                            Pessoa cliente = new Cliente();
                            cliente.Cpf = txtCpf.Text;
                            cliente = PessoaDAO.BuscarClientePorCPF(cliente);
                            if (cliente != null)
                            {
                                frmPrincipalCliente frmCliente = new frmPrincipalCliente(cliente);
                                frmCliente.ShowDialog();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Cliente sem cadastrado ");
                                Limpar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha a opcão Funcionario ou Cliente ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O CPF informado não é valido.");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o CPF");
            }
        }

        public void Limpar()
        {
            txtCpf.Clear();
            txtCpf.Focus();
        }
    }
}
