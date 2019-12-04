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
using WpfVendas.DAL;
using WpfVendas.Model;

namespace WpfVendas.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
            txtNome.Focus();
            txtCriadoEm.Text = DateTime.Now.ToString();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Produto p = new Produto
            {
                Nome = txtNome.Text,
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Preco = Convert.ToDouble(txtPreco.Text)
            };
            
            if (ProdutoDAO.CadastrarProduto(p))
            {
                MessageBox.Show("Produto Cadastrado");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Esse Produto já Existe!");
            }
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCriadoEm.Text = DateTime.Now.ToString();
            txtNome.Focus();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Produto produto = new Produto
            {
                Nome = txtNome.Text
            };
            produto = ProdutoDAO.BuscarProdutoPorNome(produto);

            if (produto!=null)
            {
                txtNome.Text = produto.Nome;
                txtPreco.Text = produto.Preco.ToString("C2");
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtCriadoEm.Text = produto.CriadoEm.ToString();
            }
            else
            {
                MessageBox.Show("Esse Produto não existe!");
            }
        }
    }
}
