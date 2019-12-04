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

namespace Wpfaula1.View
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, RoutedEventArgs e)
        {
            if (!txtNumero1.Text.Equals("")&& !txtNumero2.Text.Equals(""))
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double soma = n1 + n2;

                lblResultado.Content = "Resultado: " + soma;

                MessageBox.Show("O resultado é:" + soma, "WPF SOMA", MessageBoxButton.OK, MessageBoxImage.Information);

                txtNumero1.Clear();
                txtNumero2.Clear();
                txtNumero1.Focus();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos" , "WPF SOMA", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void TxtNumero2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNumero1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAbrirJanela_Click(object sender, RoutedEventArgs e)
        {
            frmTeste form = new frmTeste();
            form.ShowDialog();
        }
    }
}
