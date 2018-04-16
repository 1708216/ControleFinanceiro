using System.Windows;
using Controllers;
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorCadastrarNovoUsuario.xaml
    /// </summary>
    public partial class MenuAdministradorCadastrarNovoUsuario : Window
    {
        public MenuAdministradorCadastrarNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnAdminCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            ControllerUsuario cUsu = new ControllerUsuario();
            Usuario usuario = new Usuario();
            usuario.nomeUsuario = txtNomeUsuario.Text;
            usuario.loginUsuario = txtLogin.Text;
            usuario.senhaUsuario = txtSenha.Text;
            usuario.nivelDePermissão = 1;

            if (cUsu.SalvarUsuario(usuario))
            {
                MensagemDeSucesso msn = new MensagemDeSucesso();
                msn.ShowDialog();
                txtNomeUsuario.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
            }
            else
            {
                MensagemDeErro msn = new MensagemDeErro();
                msn.ShowDialog();
            }
        }
    }
}
