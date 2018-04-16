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
using Controllers;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuUsuarioAdicionarDespesaRapida.xaml
    /// </summary>
    public partial class MenuUsuarioAdicionarDespesaRapida : Window
    {
        static Despesa despesa = new Despesa();

        public MenuUsuarioAdicionarDespesaRapida()
        {
            InitializeComponent();
        }

        private void btnDespesaMercado_Click(object sender, RoutedEventArgs e)
        {
            despesa.DespesaID = 1;
            despesa.Descricao = "MERCADO";
            CadastrarDespesaClicada(despesa);
        }



        private void CadastrarDespesaClicada(Despesa despesaClicada)
        {
            ControllerDespesa Cd = new ControllerDespesa();


           // Cd.SalvarDespesa(despesaClicada);

        }
    }
}
