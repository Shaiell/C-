using System;
using ProjetoOrdemDeServico.Model;
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
    /// Interaction logic for frmAlterarProduto.xaml
    /// </summary>
    public partial class frmAlterarProduto : Window
    {
        Produto produto;
        public frmAlterarProduto(Produto p)
        {
            InitializeComponent();
            this.produto = p;
            txtDescricao.Text = p.Descricao;
            txtValor.Text = p.Valor.ToString();
            txtCategotia.Content = p.Categoria.Nome;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.produto.Descricao = txtDescricao.Text.ToString();
            this.produto.Valor = Convert.ToDouble(txtValor.Text.ToString());
            DAL.ProdutoDAO.AlterarProduto(this.produto);
                       
            MessageBox.Show("Produto alterado");

            Close();
        }
    }
}