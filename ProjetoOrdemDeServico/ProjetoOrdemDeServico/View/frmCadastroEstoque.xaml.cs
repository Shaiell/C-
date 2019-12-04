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
    /// Interaction logic for frmCadastroEstoque.xaml
    /// </summary>
    public partial class frmCadastroEstoque : Window
    {
        private Estoque estoque;
        public frmCadastroEstoque()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
            cboCategoria.ItemsSource = CategoriaDAO.BuscarCategorias();
            cboCategoria.DisplayMemberPath = "Nome";
            cboCategoria.SelectedValuePath = "CategoriaId";

            
        }

        private void CboCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<EstoqueEntrada> estoques = new List<EstoqueEntrada>();
            cboProduto.ItemsSource = ProdutoDAO.BuscarProdutosPorCategoria(Convert.ToInt32(cboCategoria.SelectedValue));
            cboProduto.DisplayMemberPath = "Descricao";
            cboProduto.SelectedValuePath = "ProdutoId";
            //List<EstoqueEntrada>estoques = EstoqueDAO.BuscarEstoquePorCategoria(Convert.ToInt32(cboCategoria.SelectedValue));
            estoques = EstoqueDAO.ListaResumidaQuantidade(Convert.ToInt32(cboCategoria.SelectedValue));

            dtGridEstoque.ItemsSource = estoques;
            estoques = null;
            //dtGridEstoque.Items.Refresh();
            
        }

        private void SalvarEstoque(object sender, RoutedEventArgs e)
        {
            Produto produto = ProdutoDAO.BuscarProdutoPorId(Convert.ToInt32(cboProduto.SelectedValue));
            estoque = null;
            estoque = new EstoqueEntrada();

            if (produto !=null)
            {
                if (!txtQuantidade.Text.Equals(""))
                {
                    if (!txtLote.Text.Equals(""))
                    {
                        estoque.Produto = produto;
                        //estoque.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                        estoque.Lote = txtLote.Text.ToString();
                        //EstoqueDAO.CadastrarItemNoEstoque(estoque);

                        estoque.Quantidade = 1;
                        int quant = Convert.ToInt32(txtQuantidade.Text);
                        for (int x = 0; x < quant; x++)
                        {
                            EstoqueDAO.CadastrarItemNoEstoque(estoque);
                        }
                        MessageBox.Show("Item Cadastrado no estoque!");
                        estoque = null;
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Preencha o Lote.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha a quantidade.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto.");
            }

           
            
        }

        private void Limpar() {
            txtLote.Text = "";
            txtQuantidade.Text = "";
            cboProduto.SelectedIndex = -1;
            int index = cboCategoria.SelectedIndex;
            cboCategoria.SelectedIndex = -1;
            cboCategoria.SelectedIndex = index;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Estoque item = (EstoqueEntrada)dtGridEstoque.SelectedItem;
            if (item !=null)
            {
                List<EstoqueEntrada> items = EstoqueDAO.BuscarEstoquePorCategoriaLote(item);
                frmExcluirItem frm = new frmExcluirItem(items);
                frm.ShowDialog();
                Limpar();
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir");
            }
           
        }
    }
}
