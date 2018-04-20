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

        private static Despesa despesaParaAdicionar;

        public MenuRegistroDetalhesDaDespesa(Despesa despesa)
        {
            InitializeComponent();
            despesaParaAdicionar = despesa;

            ControllerUsuario Cu = new ControllerUsuario();
            ComboListaUsuario.ItemsSource = Cu.RetornarListaDeTodosOsUsuarios();

        }

        private void ComboListaUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdicionarDespesa_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                RegistroDeDespesa registro = new RegistroDeDespesa();
                registro.despesa = despesaParaAdicionar;
                Usuario usuario = ComboListaUsuario.SelectedItem as Usuario;
                registro.UsuarioID = usuario.UsuarioID;
                registro.Data = DateTime.Parse(boxDataDespesa.Text);
                registro.Valor = double.Parse(txtValorDespesa.Text);
                ControllerRegistroDespesa CrDespesa = new ControllerRegistroDespesa();
                CrDespesa.SalvarRegistro(registro);
                Close();

            }
            catch(FormatException)
            {
                // personalizar uma mensagem com a informação que o campo é inválido ou em branco 

                MensagemDeErro msn = new MensagemDeErro();
                msn.ShowDialog();
            }

            

        }

        private void btnCancela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
