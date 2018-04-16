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
    /// Interaction logic for MenuRegistroDetalhesDaDespesa.xaml
    /// </summary>
    public partial class MenuRegistroDetalhesDaDespesa : Window
    {

        private static Despesa despesaAdicionar;

        public MenuRegistroDetalhesDaDespesa(Despesa despesa)
        {
            InitializeComponent();
            despesaAdicionar = despesa;
        }

        private void ComboListaUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdicionarDespesa_Click(object sender, RoutedEventArgs e)
        {
            RegistroDeDespesa registro = new RegistroDeDespesa();
            registro.despesa = despesaAdicionar; 
            registro.UsuarioID = int.Parse(txtValorDespesa.Text);
            registro.Data = DateTime.Parse(boxDataDespesa.Text);
            registro.Valor = double.Parse(txtValorDespesa.Text);

            Controller Cd = new ControllerDespesa();
            Cd.SalvarDespesa(registro);


            Close();

        }

        private void btnCancela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
