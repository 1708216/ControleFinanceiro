using System;
using System.Windows;
using System.Windows.Controls;
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
                registro._despesa = despesaParaAdicionar;
                Usuario usuario = ComboListaUsuario.SelectedItem as Usuario;
                registro.UsuarioID = usuario.UsuarioID;

                DateTime data = DateTime.Parse(boxDataDespesa.Text);
                string dataConvertida = String.Format("{0: MMMM}", data).ToLower();
                registro.Data = dataConvertida.ToUpper();
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
            catch (NullReferenceException)
            {

            }     
        }

        private void btnCancela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
