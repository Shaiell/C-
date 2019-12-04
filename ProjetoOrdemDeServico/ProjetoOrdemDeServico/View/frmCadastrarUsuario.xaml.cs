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
    /// Interaction logic for frmCadastrarUsuario.xaml
    /// </summary>
    public partial class frmCadastrarUsuario : Window
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
            txtNome.Focus();
        }
        /*Metodo criado para validar os campos vindo da tela e cadastrar o cliente/funcionario*/
        private void BtnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {


            if (txtNome.Text != "" && txtNome.Text != null)
            {
                if (txtCpf.Text != "" && txtCpf.Text != null)
                {
                    if (txtTelefone.Text != "" && txtTelefone.Text != null)
                    {
                        if (Helper.ValidarCpf(txtCpf.Text))
                        {
                            if (txtSexo.Text != "" && txtSexo.Text != null)
                            {
                                if (Convert.ToBoolean(rdFuncionario.IsChecked))
                                {
                                    Pessoa funcionario = new Funcionario
                                    {
                                        Nome = txtNome.Text,
                                        Cpf = txtCpf.Text,
                                        Telefone = txtTelefone.Text,
                                        Sexo = txtSexo.Text
                                    };
                                    if (PessoaDAO.CadastrarFuncionario(funcionario))
                                    {
                                        MessageBox.Show("Funcionario Cadastrado!");
                                        LimparTela();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Não foi passivel cadastrar, pois o CPF ja esta cadastrado em nosso sistema.");
                                    }
                                }
                                else
                                {
                                    if (Convert.ToBoolean(rdCliente.IsChecked))
                                    {
                                        Pessoa cliente = new Cliente
                                        {
                                            Nome = txtNome.Text,
                                            Cpf = txtCpf.Text,
                                            Telefone = txtTelefone.Text,
                                            Sexo = txtSexo.Text
                                        };
                                        if (PessoaDAO.CadastrarCliente(cliente))
                                        {
                                            MessageBox.Show("Cliente Cadastrado!");
                                            LimparTela();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Não foi passivel cadastrar, pois o CPF ja esta cadastrado em nosso sistema.");
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
                                MessageBox.Show("Favor preencher o Sexo.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("O CPF informado não é invalido.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor preencher o Telefone");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o CPF");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o nome");
            }
        }

        /*Metodo criado para limpar os campos do cadastro e retornar o cursor para o primeiro campo apos o cadastro de cliente/funcionario*/
        public void LimparTela()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtSexo.Clear();
            txtNome.Focus();
        }
    }
}





