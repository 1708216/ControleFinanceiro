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

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuPrincipalUsuario.xaml
    /// </summary>
    public partial class MenuPrincipalUsuario : Window
    {
        public MenuPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuLogin = new MainWindow();
            menuLogin.Show();
            Close();
        }
    }
}
