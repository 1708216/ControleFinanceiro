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
using System.Collections.ObjectModel;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuAdministradorAdicionarNomeDeDespesa.xaml
    /// </summary>
    public partial class MenuAdministradorAdicionarNomeDeDespesa : Window
    {
        public MenuAdministradorAdicionarNomeDeDespesa()
        {
            InitializeComponent();
            ControllerDespesa Cd = new ControllerDespesa();

            ComboListBoxDescricaoOperacoes.ItemsSource = Cd.RetornarListaDeDespesa();
        }


        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Despesa novaDespesa = new Despesa();
            novaDespesa.Descricao = txtBoxDescriacao.Text;
            ControllerDespesa Cd = new ControllerDespesa();
            Cd.SalvarDespesa(novaDespesa);
            MensagemDeSucesso mn = new MensagemDeSucesso();
            mn.ShowDialog();
            Close();
        }

        private void ListBoxDescricaoOperacoes_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
                
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnExcluirDescricao_Click(object sender, RoutedEventArgs e)
        {
            ControllerDespesa Cd = new ControllerDespesa();
            Despesa despesa = ComboListBoxDescricaoOperacoes.SelectedItem as Despesa;

            if( despesa.DespesaID > 28)
            {
                MensagemRatificacaoDeMudanca msn = new MensagemRatificacaoDeMudanca();
                msn.ShowDialog();
                if (msn.RetornarOpcaoExlcuirOperacao())
                {
                    Cd.ExcluirDespesa(despesa.DespesaID);
                }
                Close();
            }
            else
            {
                MensagemDeErro msn = new MensagemDeErro();
                msn.ShowDialog();
            }


        }
    }
}
