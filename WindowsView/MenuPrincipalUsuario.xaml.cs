using System.Windows;
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


        private void btnAdicionarDespesa_Click(object sender, RoutedEventArgs e)
        {
            MenuUsuarioAdicionarDespesaRapida menuDespesa = new MenuUsuarioAdicionarDespesaRapida();
            menuDespesa.ShowDialog();
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

        private void btnVisualizarReceitas_Click(object sender, RoutedEventArgs e)
        {
            MenuVisualizacaoReceitas visualizar = new MenuVisualizacaoReceitas();
            visualizar.ShowDialog();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuLogin = new MainWindow();
            menuLogin.Show();
            Close();
        }

        private void btnAdicionarReceita_Click(object sender, RoutedEventArgs e)
        {
            MenuUsuarioAdicionarReceitaRapida menuReceita = new MenuUsuarioAdicionarReceitaRapida();
            menuReceita.ShowDialog();
        }


    }
}
