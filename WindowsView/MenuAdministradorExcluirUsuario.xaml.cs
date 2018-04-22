using System.Windows;
using System.Windows.Controls;
using Controllers;
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorExcluirUsuario.xaml
    /// </summary>
    public partial class MenuAdministradorExcluirUsuario : Window
    {
        int usuarioLogadoID;

        public MenuAdministradorExcluirUsuario(int usuarioRecebidoID)
        {
            InitializeComponent();
            usuarioLogadoID = usuarioRecebidoID;
            ControllerUsuario Cu = new ControllerUsuario();
            ComboListaDeUsuarios.ItemsSource = Cu.RetornarListaDeTodosOsUsuarios();
        }

        private void btnComListaDeUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Usuario usuario = ComboListaDeUsuarios.SelectedItem as Usuario;
            txtIdExcluir.Text = usuario.UsuarioID.ToString();
            txtNomeSelecionado.Text = usuario.nomeUsuario;
            txtLogin.Text = usuario.loginUsuario;
            txtSenha.Text = usuario.senhaUsuario;
            txtNivelPermissao.Text = usuario.nivelDePermissão.ToString();
        }

        private void btnAdminExcluir_Click(object sender, RoutedEventArgs e)
        {
            int idUsuario = int.Parse(txtIdExcluir.Text);
            ControllerUsuario cu = new ControllerUsuario();

            if (cu.ExcluirUsuario(idUsuario,usuarioLogadoID))
            {
                MensagemDeSucesso msn = new MensagemDeSucesso();
                msn.ShowDialog();
                Close();
            }
            else
            {
                MensagemDeErro msn = new MensagemDeErro();
                msn.ShowDialog();
            }
        }
    }
}

