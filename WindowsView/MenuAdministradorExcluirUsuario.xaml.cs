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
    /// Interaction logic for MenuAdministradorExcluirUsuario.xaml
    /// </summary>
    public partial class MenuAdministradorExcluirUsuario : Window
    {
        public MenuAdministradorExcluirUsuario()
        {
            InitializeComponent();
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
    }
}
