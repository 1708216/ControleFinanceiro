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
    /// Interaction logic for MenuAdministradorAdicionarNomeDeReceita.xaml
    /// </summary>
    public partial class MenuAdministradorAdicionarNomeDeReceita : Window
    {
        public MenuAdministradorAdicionarNomeDeReceita()
        {
            InitializeComponent();
            ControllerReceita Cr = new ControllerReceita();
            ComboListBoxDescricaoOperacoes.ItemsSource = Cr.RetornarListaDeReceita();

        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Receita novaReceita = new Receita();
            novaReceita.Descricao = txtBoxDescriacao.Text;
            ControllerReceita Cr = new ControllerReceita();
            if (Cr.SalvarReceita(novaReceita))
            {
                MensagemDeSucesso mn = new MensagemDeSucesso();
                mn.ShowDialog();
                Close();
            }
            else
            {
                MensagemDeErro mn = new MensagemDeErro();
                mn.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtBoxDescriacao.Clear();
        }

        private void ComboListBoxDescricaoOperacoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnExcluirDescricao_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ControllerReceita Cr = new ControllerReceita();
                Receita receita = ComboListBoxDescricaoOperacoes.SelectedItem as Receita;
                MensagemRatificacaoDeMudanca msn = new MensagemRatificacaoDeMudanca();
                msn.ShowDialog();
                if (msn.RetornarOpcaoExlcuirOperacao())
                {
                    if (Cr.ExcluirReceita(receita.ReceitaID))
                    {
                        MensagemDeSucesso msnSucesso = new MensagemDeSucesso();
                        msnSucesso.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MensagemDeErro msnErro = new MensagemDeErro();
                        msnErro.ShowDialog();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MensagemDeErroPreenchimentoObrig msnCampoObrigatorio = new MensagemDeErroPreenchimentoObrig();
                msnCampoObrigatorio.ShowDialog();
            }
        }

        private void btnFecharJanela_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
