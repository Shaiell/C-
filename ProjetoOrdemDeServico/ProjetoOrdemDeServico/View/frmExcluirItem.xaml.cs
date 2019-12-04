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
    /// Interaction logic for frmExcluirItem.xaml
    /// </summary>
    public partial class frmExcluirItem : Window
    {
        List<EstoqueEntrada> itens;
        public frmExcluirItem(List<EstoqueEntrada> i)
        {
            InitializeComponent();
            this.itens = i;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboItens.ItemsSource = itens;
            cboItens.DisplayMemberPath = "DataEntrada";
            cboItens.SelectedValuePath = "EstoqueId";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cboItens.SelectedValue != null) { 
                int id = Convert.ToInt32(cboItens.SelectedValue);
                Estoque est = EstoqueDAO.BuscarEstoquePorID(id);
                EstoqueDAO.ExcluirEstoque(est);
                MessageBox.Show("Item Excluido");
            Close();
            }
            else
            {
                MessageBox.Show("Selecione um item para ser excluido.");
            }
        }
    }
}
