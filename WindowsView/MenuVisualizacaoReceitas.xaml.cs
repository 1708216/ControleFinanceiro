using System;
using System.Windows;
using System.Windows.Controls;
using Controllers;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuVisualizacaoReceitas.xaml
    /// </summary>
    public partial class MenuVisualizacaoReceitas : Window
    {
        public MenuVisualizacaoReceitas()
        {
            InitializeComponent();
            ControllerRegistroReceita CrReceitas = new ControllerRegistroReceita();
            DataGridDeReceitas.ItemsSource = CrReceitas.RetornarTodosOsRegistrosReceitas();
            //bloqueia a edição do DataGrid
            DataGridDeReceitas.IsReadOnly = true;
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
