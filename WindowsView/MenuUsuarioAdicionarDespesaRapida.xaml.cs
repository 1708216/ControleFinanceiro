using System.Windows;
using Model;
using Controllers;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuUsuarioAdicionarDespesaRapida.xaml
    /// </summary>
    /// 

    public partial class MenuUsuarioAdicionarDespesaRapida : Window
    {
        private static Despesa despesa = new Despesa();
        private static ControllerDespesa Cd = new ControllerDespesa();

        public MenuUsuarioAdicionarDespesaRapida()
        {
            InitializeComponent();
        }

        private void CadastrarDespesaClicada(string nomeDespesaClicada)
        {
            try
            {
                despesa = Cd.ProcurarDespesaPorNome(nomeDespesaClicada);
            }
            catch (ResourceReferenceKeyNotFoundException)
            {
                //criar mensagem personalizada.
            }

            MenuRegistroDetalhesDaDespesa rgDetalhes = new MenuRegistroDetalhesDaDespesa(despesa);
            rgDetalhes.ShowDialog();
        }



        private void btnDespesaMercado_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("MERCADO");
        }

        private void btnDespesaInternet_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("INTERNET");
        }

        private void btnDespesaLuz_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("LUZ");
        }

        private void btnDespesaAgua_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("ÁGUA");
        }

        private void btnDespesaCarataoCredito_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("CARTÃO DE CRÉDITO");

        }

        private void btnDespesaEducacao_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("EDUCAÇÃO");
        }

        private void btnDespesaSeguroCarro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("SEGURO DO CARRO");
        }

        private void btnDespesaLanche_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("LANCHE");
        }

        private void btnDespesaAlmoco_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("ALMOÇO");
        }

        private void brnDespesaMecanico_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("MECÂNICO");
        }

        private void btnDespesaAcademia_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("ACADEMIA");
        }

        private void btnDespesaMedico_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("DESPESAS MÉDICAS");
        }

        private void btnDespesaBar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("BAR");
        }

        private void btnDespesaOdontológica_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("DENTISTA");
        }

        private void btnDespesaCabeleireiro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("SALÃO DE BELEZA");
        }

        private void btnDespesaEmpregadaDomestica_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("EMPREGADA DOMÉSTICA");
        }

        private void btnDespesaGasolina_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("GASOLINA");
        }

        private void btnDespesaCondominio_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("CONDOMÍNIO");
        }

        private void btnDespesaIPVA_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("IPVA");
        }

        private void btnDespesaGas_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("GÁS");
        }

        private void btnDespesaViagem_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("DESPESAS COM VIAGEM");
        }

        private void btnDespesaPresente_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("PRESENTE");
        }

        private void btnDespesaFinanciamentoImobiliario_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("FINANCIAMENTO IMOBILIÁRIO");
        }

        private void btnDespesaIPTU1_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("IPTU");
        }

        private void btnDespesaRemedio_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("FARMÁCIA");
        }

        private void btnDespesaCelular_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("PLANO DO CELULAR");
        }

        private void btnDespesaLazer_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("LAZER");
        }
    }
}
