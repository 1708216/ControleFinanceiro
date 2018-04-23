using System.Windows;
using System.Windows.Controls;
using Controllers;
using Model;
using System;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorCadastrarNovoUsuario.xaml
    /// </summary>
    public partial class MenuAdministradorCadastrarNovoUsuario : Window
    {
        int permissao = 2;
        
        public MenuAdministradorCadastrarNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnAdminCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ControllerUsuario cUsu = new ControllerUsuario();
                Usuario usuario = new Usuario();
                usuario.nomeUsuario = txtNomeUsuario.Text;
                usuario.loginUsuario = txtLogin.Text;
                usuario.senhaUsuario = txtSenha.Text;
                usuario.nivelDePermissão = permissao;

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
            catch (NullReferenceException)
            {
                MensagemDeErroPreenchimentoObrig msnErro = new MensagemDeErroPreenchimentoObrig();
                msnErro.ShowDialog();
            }
        }

        private void btnCancelarCadastro_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if ((radio.Content.ToString()).Equals("Administrador"))
            {
                permissao = 1;      
            }
            else
            {
                permissao = 2;
            }

        }
    }
}
