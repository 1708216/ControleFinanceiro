using System.Windows;
using System.Windows.Controls;
using Controllers;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuVisualizacaoDespesas.xaml
    /// </summary>
    public partial class MenuVisualizacaoDespesas : Window
    {
        public MenuVisualizacaoDespesas()
        {
            InitializeComponent();
            ControllerRegistroDespesa CrDespesas = new ControllerRegistroDespesa();
            DataGridDeDespesas.ItemsSource = CrDespesas.RetornarTodosOsRegistrosDespesas();
               //bloqueia a edição do DataGrid
            DataGridDeDespesas.IsReadOnly = true;
        }

        private void DataGridDeDespesas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
