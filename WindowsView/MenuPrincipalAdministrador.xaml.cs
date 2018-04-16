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
    }
}
