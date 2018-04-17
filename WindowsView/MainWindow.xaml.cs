using System.Windows;
using Controllers;
using Model;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum TipoDePermissao
        {
            administrador = 1,
            usuarioPadrão = 2,
        }

        public MainWindow()
        {
            CriarAdmin();
            CriarUsu();
            CriarDespesaMercado();
            CriarDespesaInternet();
            InitializeComponent();
        }

        public void CriarAdmin()
        {
            Usuario usuario = new Usuario();
            ControllerUsuario cUsu = new ControllerUsuario();
            usuario.loginUsuario = "admin";
            usuario.nomeUsuario = "Administrador";
            usuario.senhaUsuario = "123";
            usuario.nivelDePermissão = 1;
            cUsu.SalvarUsuario(usuario);

        }
        public void CriarUsu()
        {
            Usuario usuario = new Usuario();
            ControllerUsuario cUsu = new ControllerUsuario();
            usuario.loginUsuario = "marcelo";
            usuario.nomeUsuario = "Marcelo";
            usuario.senhaUsuario = "123";
            usuario.nivelDePermissão = 2;
            cUsu.SalvarUsuario(usuario);

        }

        public void CriarDespesaMercado()
        {
            Despesa despesa = new Despesa();
            ControllerDespesa Cdes = new ControllerDespesa();
            despesa.Descricao = "MERCADO";
            Cdes.SalvarDespesa(despesa);
        }
        public void CriarDespesaInternet()
        {
            Despesa despesa = new Despesa();
            ControllerDespesa Cdes = new ControllerDespesa();
            despesa.Descricao = "INTERNET";
            Cdes.SalvarDespesa(despesa);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            ControllerUsuario cUsuario = new ControllerUsuario();

            usuario.loginUsuario = btnAcessoLogin.Text;
            usuario.senhaUsuario = btnSenha.Password;

            if (cUsuario.ValidarLoginESenha(usuario))
            {
                Usuario usuarioParaPermissao = cUsuario.ProcurarUsuarioPorLogin(usuario.loginUsuario);
                if (TipoDePermissao.administrador == (TipoDePermissao)usuarioParaPermissao.nivelDePermissão)
                {
                    MenuPrincipalAdministrador mnAdmin = new MenuPrincipalAdministrador(usuarioParaPermissao);
                    Close();
                    mnAdmin.Show();
                }
                else
                {
                    MenuPrincipalUsuario mnUsuario = new MenuPrincipalUsuario(usuarioParaPermissao);
                    Close();
                    mnUsuario.Show();
                }
            }
            else
            {
                MensagemErroLoginOuSenha msn = new MensagemErroLoginOuSenha();
                msn.ShowDialog();
            }

        }
    }
}
