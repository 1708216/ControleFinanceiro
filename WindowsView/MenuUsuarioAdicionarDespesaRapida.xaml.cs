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

        private void btnDespesaMercado_Click(object sender, RoutedEventArgs e)
        {     
             CadastrarDespesaClicada("MERCADO");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDespesaClicada("INTERNET");
        }


        private void CadastrarDespesaClicada(string nomeDespesaClicada)
        {
            //criar um método para retornar o id da despesa e inserir no registro;
            despesa = Cd.ProcurarDespesaPorNome(nomeDespesaClicada);

            //if (despesa == null)
            //{
            //    Despesa despesa = new Despesa();
            //    despesa.Descricao = nomeDespesaClicada;

            //}

            MenuRegistroDetalhesDaDespesa rgDetalhes = new MenuRegistroDetalhesDaDespesa(despesa);
            rgDetalhes.ShowDialog();
        }

    }
}
