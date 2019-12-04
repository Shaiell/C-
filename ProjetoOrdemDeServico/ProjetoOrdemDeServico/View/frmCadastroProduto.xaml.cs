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
    /// Interaction logic for frmCadastroProduto.xaml
    /// </summary>
    public partial class frmCadastroProduto : Window
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
            txtDescricao.Focus();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboCategoriaCadastro.ItemsSource = CategoriaDAO.BuscarCategorias();
            cboCategoriaCadastro.DisplayMemberPath = "Nome";
            cboCategoriaCadastro.SelectedValuePath = "CategoriaId";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int idCategoria = Convert.ToInt32(cboCategoriaCadastro.SelectedValue);
            if (!txtDescricao.Text.Equals(""))
            {
                if (!txtValor.Text.Equals(""))
                {
                    if (cboCategoriaCadastro.SelectedValue != null)
                    {
                        Categoria cat = CategoriaDAO.BuscarCategoriasPorID(idCategoria);

                        Model.Produto produto = new Model.Produto();
                        produto.Descricao = txtDescricao.Text.ToString();
                        produto.Valor = Convert.ToDouble(txtValor.Text.ToString());
                        produto.Categoria = cat;
                        ProdutoDAO.CadastrarProduto(produto);
                        MessageBox.Show("Produto Cadastrado");
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher o campo Categoria.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo Valor.");
                }
            }
            else {
                MessageBox.Show("Favor preencher o campo descrição.");
            }
        }

        public void Limpar()
        {
            txtValor.Clear();
            txtDescricao.Clear();
            cboCategoriaCadastro.SelectedIndex = -1;
            txtDescricao.Focus();
        }
    }
}
