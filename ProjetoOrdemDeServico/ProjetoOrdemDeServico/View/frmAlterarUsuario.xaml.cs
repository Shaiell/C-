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
    /// Interaction logic for frmAlterarCliente.xaml
    /// </summary>
    public partial class frmAlterarUsuario : Window
    {
        Pessoa usuario;
        public frmAlterarUsuario(Pessoa c)
        {
            InitializeComponent();
            this.usuario = c;
            txtNome.Text = c.Nome;
            txtTelefone.Text = c.Telefone;
            txtSexo.Text = c.Sexo;
        }

        private void BtnAlterarCadastro(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text != "" && txtNome.Text != null)
            {
               
                    if (txtTelefone.Text != "" && txtTelefone.Text != null)
                    {
                        if (txtSexo.Text != "" && txtSexo.Text != null)
                        {
                        usuario.Nome = txtNome.Text.ToString();
                        usuario.Telefone = txtTelefone.Text.ToString();
                        usuario.Sexo = txtSexo.Text.ToString();
                        PessoaDAO.AlterarPessoa(usuario);
                        MessageBox.Show("Cadastro Alterado.");
                        Close();

                    }
                        else
                        {
                            MessageBox.Show("Favor preencher o Sexo");
                        }

                }
                    else
                    {
                        MessageBox.Show("Favor preencher o Telefone");
                    }
                
            }
            else
            {
                MessageBox.Show("Favor preencher o nome");
            }
        }
    }
    
}


