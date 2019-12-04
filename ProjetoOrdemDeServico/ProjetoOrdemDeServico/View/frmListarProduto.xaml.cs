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
    /// Interaction logic for frmListarProduto.xaml
    /// </summary>
    public partial class frmListarProduto : Window
    {
        int index;
        
        public frmListarProduto()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboCategoriaListarProduto.ItemsSource = CategoriaDAO.BuscarCategorias();
            cboCategoriaListarProduto.DisplayMemberPath = "Nome";
            cboCategoriaListarProduto.SelectedValuePath = "CategoriaId";
        }

        private void CboCategoriaListarProduto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCategoria = Convert.ToInt32(cboCategoriaListarProduto.SelectedValue);
            List<Model.Produto> listaDeProdutos = new List<Model.Produto>();
            listaDeProdutos = ProdutoDAO.BuscarProdutosPorCategoria(idCategoria);

            dtaListarProduto.ItemsSource = listaDeProdutos;
            dtaListarProduto.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.Produto produto = (Model.Produto) dtaListarProduto.SelectedItem;
            if (produto != null)
            {
                frmAlterarProduto frmAlterarProduto = new frmAlterarProduto(produto);
                frmAlterarProduto.ShowDialog();
                index = cboCategoriaListarProduto.SelectedIndex;
                cboCategoriaListarProduto.SelectedIndex = -1;
                cboCategoriaListarProduto.SelectedIndex = index;
            }else
            {
                MessageBox.Show("Selecione um item para alterar");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int idCategoria = Convert.ToInt32(cboCategoriaListarProduto.SelectedValue);
            if (!txtDescricao.Text.Equals(""))
            {
                if (!txtValor.Text.Equals(""))
                {
                    if (cboCategoriaListarProduto.SelectedValue != null)
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
            else
            {
                MessageBox.Show("Favor preencher o campo descrição.");
            }
        }

        public void Limpar()
        {
            txtValor.Clear();
            txtDescricao.Clear();
            index = cboCategoriaListarProduto.SelectedIndex;
            cboCategoriaListarProduto.SelectedIndex = -1;
            cboCategoriaListarProduto.SelectedIndex = index;
            txtDescricao.Focus();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Produto produto = (Produto)dtaListarProduto.SelectedItem;
            if (produto != null)
            {
                if (EstoqueDAO.BuscarEstoquePorIdProduto(produto.ProdutoId) != null)
                {
                    MessageBox.Show("Não é possivel excluir item pois já \nexiste lançamento no estoque.");
                }
                else
                {
                    ProdutoDAO.ExcluirProduto(produto);
                    MessageBox.Show("Produto excluido.");
                    index = cboCategoriaListarProduto.SelectedIndex;
                    cboCategoriaListarProduto.SelectedIndex = -1;
                    cboCategoriaListarProduto.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir");
            }
            
        }
    }
}
