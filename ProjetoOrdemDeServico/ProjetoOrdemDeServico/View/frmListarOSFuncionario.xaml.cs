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
    /// Interaction logic for frmListarOSFuncionario.xaml
    /// </summary>
    public partial class frmListarOSFuncionario : Window
    {
        Pessoa Funcionario;
        public frmListarOSFuncionario(Pessoa f)
        {
            InitializeComponent();
            this.Funcionario = f;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGridALiberara();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
            OrdemDeServico os = (OrdemDeServico)dtaLiberar.SelectedItem;

                if (dteInicio.SelectedDate != null)
                {
                    if (dteTermino.SelectedDate != null)
                    {
                        if (os != null)
                        {
                            os.InicioProducao = dteInicio.SelectedDate;
                            os.TerminoProducao = dteTermino.SelectedDate;
                            os.Funcionario = Funcionario;
                            os.Aprovado = true;
                            EstoqueSaida item = new EstoqueSaida();
                            item = (EstoqueSaida)os.Processador;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);
                            
                            item = new EstoqueSaida();
                            item = (EstoqueSaida)os.PlacaMae;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);
                           
                            item = new EstoqueSaida();
                            item = (EstoqueSaida)os.Memoria;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);
                           
                            item = new EstoqueSaida();
                            item = (EstoqueSaida)os.PlacaVideo;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);
                            
                            item = new EstoqueSaida();
                            item = (EstoqueSaida)os.Hd;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);
                            
                            item = new EstoqueSaida();
                            item = (EstoqueSaida)os.Ssd;
                            item.OrdemDeServico = os.OrdemId;
                            EstoqueDAO.AlterarEstoque(item);

                            OrdemDeServicoDAO.LiberarOrdemServico(os);


                        MessageBox.Show("OS Liberada para produção.");
                            LoadGridALiberara();
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma ordem de serviço.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe a data de Termino de Produção.");
                    }
                }
                else
                {
                    MessageBox.Show("Informe a data de Inicio de Produção.");
                }

        }
            
    

        public void LoadGridALiberara()
        {
            dtaLiberar.ItemsSource = OrdemDeServicoDAO.ListarOsALiberarTodos();
            dtaLiberada.ItemsSource = OrdemDeServicoDAO.ListarOsLiberadasTodos();
        }

      
    }
}
