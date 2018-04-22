using System.Windows;
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuPrincipalAdministrador.xaml
    /// </summary>
    public partial class MenuPrincipalAdministrador : Window
    {
        static Usuario usuarioLogado = new Usuario();

        public MenuPrincipalAdministrador(Usuario usuarioRecebido)
        {
            usuarioLogado = usuarioRecebido;
            InitializeComponent();
            nomeUsuario.Text = "Olá, " + usuarioLogado.nomeUsuario + " !";
        }

        private void btnAdminCadastarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MenuAdministradorCadastrarNovoUsuario mnCadastrar = new MenuAdministradorCadastrarNovoUsuario();
            mnCadastrar.ShowDialog();
        }

        private void btnExclurUsuario_Click(object sender, RoutedEventArgs e)
        {
            MenuAdministradorExcluirUsuario mnExcluir = new MenuAdministradorExcluirUsuario(usuarioLogado.UsuarioID);
            mnExcluir.ShowDialog();
        }

        private void btnAdmEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MenuAdministradorEditarUsuario mnEditar = new MenuAdministradorEditarUsuario();
            mnEditar.ShowDialog();
        }

        private void btnCadastrarOperacao_Click(object sender, RoutedEventArgs e)
        {
            MenuAdministradorAdicionarNomeDeDespesa mnAdicionarNomeDespesa = new MenuAdministradorAdicionarNomeDeDespesa();
            mnAdicionarNomeDespesa.ShowDialog();
        }

        private void btnSairDoMenuAdmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mnLogin = new MainWindow();
            mnLogin.Show();
            Close();
        }
    }
}
