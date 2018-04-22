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
using Controllers;
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorEditarUsuario.xaml
    /// </summary>
    public partial class MenuAdministradorEditarUsuario : Window
    {
        public MenuAdministradorEditarUsuario()
        {
            InitializeComponent();
            ControllerUsuario cu = new ControllerUsuario();
            ComboListaDeUsuarios.ItemsSource = cu.RetornarListaDeTodosOsUsuarios();
        }

        private void btnComListaDeUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Usuario usuario = ComboListaDeUsuarios.SelectedItem as Usuario;
            txtIdEditar.Text = usuario.UsuarioID.ToString();
            txtNomeSelecionado.Text = usuario.nomeUsuario;
            txtLogin.Text = usuario.loginUsuario;
            txtSenha.Text = usuario.senhaUsuario;
            txtNivelPermissao.Text = usuario.nivelDePermissão.ToString();

        }

        private void btnAdminSalvarEditar_Click(object sender, RoutedEventArgs e)
        {

            ControllerUsuario cU = new ControllerUsuario();
            Usuario usuario = new Usuario();

            usuario.UsuarioID = int.Parse(txtIdEditar.Text);
            usuario.nomeUsuario = txtNomeSelecionado.Text;
            usuario.loginUsuario = txtLogin.Text;
            usuario.senhaUsuario = txtSenha.Text;
            usuario.nivelDePermissão = Convert.ToInt32(txtNivelPermissao.Text);

            if (cU.EditarUsuario(usuario))
            {
                MensagemDeSucesso msn = new MensagemDeSucesso();
                msn.ShowDialog();
            }
            else
            {
                MensagemDeErro msn = new MensagemDeErro();
                msn.ShowDialog();
            }
        }

        private void btnCancelarMnEditar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
