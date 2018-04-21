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
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuPrincipalUsuario.xaml
    /// </summary>
    public partial class MenuPrincipalUsuario : Window
    {

        static Usuario usuarioLogado = new Usuario();

        public MenuPrincipalUsuario(Usuario usuarioRecebido)
        {
            usuarioLogado = usuarioRecebido;
            InitializeComponent();
            nomeUsuario.Text = "Olá, " + usuarioLogado.nomeUsuario;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuLogin = new MainWindow();
            menuLogin.Show();
            Close();
        }

        private void btnAdicionarDespesa_Click_1(object sender, RoutedEventArgs e)
        {
            
            MenuUsuarioAdicionarDespesaRapida mnAddDespesaRapida = new MenuUsuarioAdicionarDespesaRapida();
            mnAddDespesaRapida.ShowDialog();

        }

        private void btnVisualizarDespesas_Click(object sender, RoutedEventArgs e)
        {
            MenuVisualizacaoDespesas visualizar = new MenuVisualizacaoDespesas();
            visualizar.ShowDialog();
        }

        private void btnVisualizarSituacaFinanceira_Click(object sender, RoutedEventArgs e)
        {
            MenuDeRelatorioDeGastosDoMes menuMes = new MenuDeRelatorioDeGastosDoMes();
            menuMes.ShowDialog();
        }
    }
}
