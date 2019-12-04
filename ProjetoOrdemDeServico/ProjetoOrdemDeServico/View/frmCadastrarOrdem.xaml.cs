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
    /// Interaction logic for frmCadastrarOrdem.xaml
    /// </summary>
    public partial class frmCadastrarOrdem : Window
    {
        
        private Pessoa Cliente;

        public frmCadastrarOrdem(Pessoa c)
        {
            InitializeComponent();
            this.Cliente = c;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarComboBox();
            LoadGridALiberara();
        }

        private void CarregarComboBox()
        {
            //Combobox Processador
            cboProcessador.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.PROCESSADOR);
            cboProcessador.DisplayMemberPath = "Produto.Descricao";
            cboProcessador.SelectedValuePath = "EstoqueId";

            //Combobox Placa mãe
            cboPlacaMae.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.PLACA_MAE);
            cboPlacaMae.DisplayMemberPath = "Produto.Descricao";
            cboPlacaMae.SelectedValuePath = "EstoqueId";

            //Combobox Memoria
            cboMemoria.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.MEMORIA);
            cboMemoria.DisplayMemberPath = "Produto.Descricao";
            cboMemoria.SelectedValuePath = "EstoqueId";

            //Combobox Placa de video
            cboPlacaVideo.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.PLACA_DE_VIDEO);
            cboPlacaVideo.DisplayMemberPath = "Produto.Descricao";
            cboPlacaVideo.SelectedValuePath = "EstoqueId";

            //Combobox HD
            cboHd.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.HD);
            cboHd.DisplayMemberPath = "Produto.Descricao";
            cboHd.SelectedValuePath = "EstoqueId";

            //Combobox SSD
            cboSsd.ItemsSource = EstoqueDAO.ListaResumidacadastro(Constants.SSD);
            cboSsd.DisplayMemberPath = "Produto.Descricao";
            cboSsd.SelectedValuePath = "EstoqueId";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrdemDeServico os = new OrdemDeServico(this.Cliente);
            Estoque itemEntrada;
            EstoqueSaida itemSaida;

            if (cboProcessador.SelectedIndex != -1)
            {
                if (cboPlacaMae.SelectedIndex != -1)
                {
                    if (cboMemoria.SelectedIndex != -1)
                    {
                        if (cboPlacaVideo.SelectedIndex != -1)
                        {
                            if (cboHd.SelectedIndex != -1)
                            {
                                if (cboSsd.SelectedIndex != -1)
                                {
                                    //Cadastrdo do processador
                                    itemEntrada = new EstoqueEntrada();
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboProcessador.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.Processador = itemSaida;

                                    //Cadastrdo da Placa Mãe
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = new EstoqueEntrada();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboPlacaMae.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.PlacaMae = itemSaida;

                                    //Cadastrdo da Memoria
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = new EstoqueEntrada();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboMemoria.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.Memoria = itemSaida;

                                    //Cadastrdo da Placa de video
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = new EstoqueEntrada();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboPlacaVideo.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.PlacaVideo = itemSaida;

                                    //Cadastrdo da HD
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = new EstoqueEntrada();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboHd.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.Hd = itemSaida;

                                    //Cadastrdo da SSD
                                    itemSaida = new EstoqueSaida();
                                    itemEntrada = new EstoqueEntrada();
                                    itemEntrada = EstoqueDAO.BuscarEstoquePorID(Convert.ToInt32(cboSsd.SelectedValue));
                                    itemSaida.DataEntrada = itemEntrada.DataEntrada;
                                    itemSaida.Lote = itemEntrada.Lote;
                                    itemSaida.Produto = itemEntrada.Produto;
                                    itemSaida.Quantidade = 1;
                                    EstoqueDAO.CadastrarItemNoEstoque(itemSaida);
                                    EstoqueDAO.ExcluirEstoque(itemEntrada);
                                    os.Ssd = itemSaida;

                                    OrdemDeServicoDAO.CadastrarOs(os);
                                    MessageBox.Show("Ordem de serviço enviada para Aprovação!");
                                    LoadGridALiberara();
                                    Limpar();
                                }
                                else
                                {
                                    MessageBox.Show("Selecione um SSD");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Selecione um HD");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma Placa de Video");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma Memoria");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Palca Mãe");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Processador");
            }
        }
        public void Limpar()
        {
            cboProcessador.SelectedIndex = -1;
            cboPlacaMae.SelectedIndex = -1;
            cboMemoria.SelectedIndex = -1;
            cboPlacaVideo.SelectedIndex = -1;
            cboHd.SelectedIndex = -1;
            cboSsd.SelectedIndex = -1;
        }

        public void LoadGridALiberara()
        {
            dtaLiberar.ItemsSource = OrdemDeServicoDAO.ListarOsALiberarPorPessoa(this.Cliente);
            dtaLiberada.ItemsSource = OrdemDeServicoDAO.ListarOsLiberadasPorPessoa(this.Cliente);
        }
    }
}
