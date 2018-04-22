using System.Windows;
using System.Windows.Controls;
using Model;
using Controllers;


namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuUsuarioAdicionarReceita.xaml
    /// </summary>
    public partial class MenuUsuarioAdicionarReceitaRapida : Window
    {
        private static Receita receita = new Receita();
        private static ControllerReceita Cr = new ControllerReceita();


        public MenuUsuarioAdicionarReceitaRapida()
        {
           InitializeComponent();
        }

        private void CadastrarReceitaClicada(string nomeReceitaClicada)
        {
            try
            {
                receita = Cr.ProcurarReceitaPorNome(nomeReceitaClicada);
            }
            catch (ResourceReferenceKeyNotFoundException)
            {
                //criar mensagem personalizada.
            }
            MenuRegistroDetalhesDaReceita rgDetalhes = new MenuRegistroDetalhesDaReceita(receita);
            rgDetalhes.ShowDialog();
        }

        private void ComboListaUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void btnReceitaSalario_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("SALÁRIO");
        }

        private void btnReceitaBolsaDeEstudo_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("BOLSA DE ESTUDOS");
        }

        private void btnReceitaAluguel_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("ALUGUEL”");
        }

        private void btnReceita13Salario_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("13 SALÁRIO");
        }

        private void btnReceitaFerias_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("FÉRIAS");
        }

        private void btnReceitaInvestimento_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("INVESTIMENTOS");
        }

        private void brnReceitaPensao_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("PENSÃO");
        }

        private void btnRecitaRestitiucao_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("RESTITUIÇÃO DO IRRF");
        }

        private void btnReceitaHoraExtra_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("HORAS EXTRAS");
        }

        private void btnReceitaAposentadoria_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("APOSENTADORIA");
        }

        private void btnReceitaVendaExtra_Click(object sender, RoutedEventArgs e)
        {
            CadastrarReceitaClicada("APOSENTADORIA");
        }

        private void btnFecharJanela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
