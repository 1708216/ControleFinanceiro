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

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MenuDeRelatorioDeGastosDoMes.xaml
    /// </summary>
    public partial class MenuDeRelatorioDeGastosDoMes : Window
    {

        public MenuDeRelatorioDeGastosDoMes()
        {

             InitializeComponent();
             ComboBoxMesRelatorio.ItemsSource = ListaDeMeses();

        }


        private void txtTotalDespesa_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void ComboBoxMesRelatorio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string mesSelecionado = ComboBoxMesRelatorio.SelectedItem.ToString();
                ControllerRegistroDespesa Cd = new ControllerRegistroDespesa();
                ControllerRegistroReceita Cr = new ControllerRegistroReceita();
                double totalDespesa = Cd.RetornarSomaDasDespesaDoMes(mesSelecionado);
                double totalReceita = Cr.RetornarSomaDasReceitasDoMes(mesSelecionado);
                txtTotalDespesa.Text = totalDespesa.ToString();
                txtTotalReceita.Text = totalReceita.ToString();
                txtResultadoFinal.Text = (totalReceita - totalDespesa).ToString();


                //Mudando a Abordagem para realizar o cálculo final.
                 //txtTotalDespesa.Text = Cd.RetornarSomaDasDespesaDoMes(mesSelecionado).ToString();
                //ControllerRegistroReceita Cr = new ControllerRegistroReceita();
                //txtTotalReceita.Text = Cr.RetornarSomaDasReceitasDoMes(mesSelecionado).ToString();
            }
            catch (NullReferenceException)
            {

            }

        }

        private List<String> ListaDeMeses()
        {
            List<String> meses = new List<String>();

            meses.Add("JANEIRO");
            meses.Add("FEVEREIRO");
            meses.Add("MARÇO");
            meses.Add("ABRIL");
            meses.Add("MAIO");
            meses.Add("JUNHO");
            meses.Add("JULHO");
            meses.Add("AGOSTO");
            meses.Add("SETEMBRO");
            meses.Add("OUTUBRO");
            meses.Add("NOVEMBRO");
            meses.Add("DEZEMBRO");
            return meses;
        }


    }
}
