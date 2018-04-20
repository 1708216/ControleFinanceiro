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
using Controllers;
using Model;

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
