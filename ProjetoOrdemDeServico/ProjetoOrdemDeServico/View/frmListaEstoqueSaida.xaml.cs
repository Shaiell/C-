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
    /// Interaction logic for frmListaEstoqueSaida.xaml
    /// </summary>
    public partial class frmListaEstoqueSaida : Window
    {
        List<EstoqueSaida> estoque;
        public frmListaEstoqueSaida()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboOs.ItemsSource = OrdemDeServicoDAO.ListarTodasAsOrdens();
            cboOs.DisplayMemberPath = "OrdemId";
            cboOs.SelectedValuePath = "OrdemId";

            if (cboOs.SelectedIndex == -1)
            {
                estoque = null;
                estoque = EstoqueDAO.BuscarTodaListaDeSaida();
                dtGridEstoqueSaida.ItemsSource = estoque;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cboOs.SelectedIndex = -1;
            estoque = EstoqueDAO.BuscarTodaListaDeSaida();
            dtGridEstoqueSaida.ItemsSource = estoque;
        }

        private void CboOs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            estoque= null;
            int id = Convert.ToInt32(cboOs.SelectedValue);
            estoque = EstoqueDAO.BuscarListaDeSaidaPorID(id);
            dtGridEstoqueSaida.ItemsSource = estoque;
        }
    }
}
