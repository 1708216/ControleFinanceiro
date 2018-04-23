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
    /// Interaction logic for MenuRegistroDetalhesDaReceita.xaml
    /// </summary>
    public partial class MenuRegistroDetalhesDaReceita : Window
    {
        private static Receita receitaParaAdicionar;

        public MenuRegistroDetalhesDaReceita(Receita receita)
        {
            InitializeComponent();
            receitaParaAdicionar = receita;
            ControllerUsuario Cu = new ControllerUsuario();
            ComboListaUsuario.ItemsSource = Cu.RetornarListaDeTodosOsUsuarios();

        }

        private void ComboListaUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdicionarReceita_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegistroDeReceita registro = new RegistroDeReceita();
                registro._receita = receitaParaAdicionar;
                Usuario usuario = ComboListaUsuario.SelectedItem as Usuario;
                registro.UsuarioID = usuario.UsuarioID;

                DateTime data = DateTime.Parse(boxDataReceita.Text);
                string dataConvertida = string.Format("{0:MMMM}", data);
                registro.Data = dataConvertida.ToUpper();
                registro.Valor = double.Parse(txtValorReceita.Text);
                ControllerRegistroReceita CrReceita = new ControllerRegistroReceita();
                CrReceita.SalvarRegistro(registro);
                Close();
            }
            catch (FormatException)
            {

                MensagemDeErroCampoInvalido msnCampoInvalido = new MensagemDeErroCampoInvalido();
                msnCampoInvalido.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MensagemDeErroPreenchimentoObrig msnCampoObrigatorio = new MensagemDeErroPreenchimentoObrig();
                msnCampoObrigatorio.ShowDialog();
            }
        }

        private void btnCancela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
