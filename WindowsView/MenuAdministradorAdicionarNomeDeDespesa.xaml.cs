using System.Windows;
using System.Windows.Controls;
using Controllers;
using Model;


namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorAdicionarNomeDeDespesa.xaml
    /// </summary>
    public partial class MenuAdministradorAdicionarNomeDeDespesa : Window
    {
        public MenuAdministradorAdicionarNomeDeDespesa()
        {


            InitializeComponent();
            ControllerDespesa Cd = new ControllerDespesa();
            ComboListBoxDescricaoOperacoes.ItemsSource = Cd.RetornarListaDeDespesa();
        }


        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Despesa novaDespesa = new Despesa();
            novaDespesa.Descricao = txtBoxDescriacao.Text;
            ControllerDespesa Cd = new ControllerDespesa();
            Cd.SalvarDespesa(novaDespesa);
            MensagemDeSucesso mn = new MensagemDeSucesso();
            mn.ShowDialog();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnExcluirDescricao_Click(object sender, RoutedEventArgs e)
        {
            ControllerDespesa Cd = new ControllerDespesa();
            Despesa despesa = ComboListBoxDescricaoOperacoes.SelectedItem as Despesa;
            MensagemRatificacaoDeMudanca msn = new MensagemRatificacaoDeMudanca();
            msn.ShowDialog();

            if (msn.RetornarOpcaoExlcuirOperacao())
            {
            

                if (Cd.ExcluirDespesa(despesa.DespesaID))
                {
                    MensagemDeSucesso msnSucesso = new MensagemDeSucesso();
                    msnSucesso.ShowDialog();
                    Close();
                }
                else
                {
                    MensagemDeErro msnErro = new MensagemDeErro();
                    msnErro.ShowDialog();
                }
            }

        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtBoxDescriacao.Clear();
        }

        private void ListBoxDescricaoOperacoes_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void ComboListBoxDescricaoOperacoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
