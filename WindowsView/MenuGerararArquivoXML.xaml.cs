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
using ClosedXML.Excel;
using System.IO;

namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MunuGerararArquivoXML.xaml
    /// </summary>
    public partial class MenuGerarArquivoXML : Window
    {

        List<RegistroDeDespesa> registrosDeDespesas = new List<RegistroDeDespesa>();

        public MenuGerarArquivoXML()
        {
            InitializeComponent();
            ComboBoxMesesDoAno.ItemsSource = ListaDeMeses();
        }

        private void ComboBoxMesesDoAno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ControllerRegistroDespesa Cr = new ControllerRegistroDespesa();
            String mes = ComboBoxMesesDoAno.SelectedItem as String;
            DataGridDeDespesas.ItemsSource = Cr.RetornarAsDespesaDoMes(mes).ToList();
            registrosDeDespesas = Cr.RetornarAsDespesaDoMes(mes).ToList();

        }

        private void btnGerarPlanilhaXml_Click(object sender, RoutedEventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Planilha  1");


            //unindo as células para inserir otítulo
            
            ws.Cell("B2").Value = " RELATÓRIO MENSAL";
            var range = ws.Range("B2:H2");
            range.Merge().Style.Font.SetBold().Font.FontSize = 20;

            // Cabeçalhos do Relatório
            ws.Cell("C3").Value = "ID Registro";
            ws.Cell("D3").Value = "ID Despesa";
            ws.Cell("E3").Value = "DESCRIÇÃO";
            ws.Cell("F3").Value = "MÊS";
            ws.Cell("G3").Value = "VALOR";
            ws.Cell("H3").Value = "USUARIO";


            // Corpo do relatório
            var linha = 4;
            var rangeWithData = ws.Cell(4, 2).InsertData(registrosDeDespesas.AsEnumerable());
           
            //// Ajusto a numeração da linha
             linha++;
      
            
           // Crio uma Tabela para ativar os Filtros
            range = ws.Range("C3:H" + linha.ToString());
            range.CreateTable();
            
            // Ajusto o tamanho da coluna com o conteúdo da coluna
            ws.Columns("3-8").AdjustToContents();

            try
            {
                // Salvar o arquivo em Disco
                wb.SaveAs(@"C:\Users\marce\Documents\testesplanilhas\planilhaDeGastos.xlsx");

                MensagemDeSucesso msn = new MensagemDeSucesso();
                msn.ShowDialog();

            }
            catch (IOException)
            {
                MensagemDeErro msnErroJaUsado = new MensagemDeErro();
                msnErroJaUsado.ShowDialog();
            }
            finally
            {
                // Liberar objetos
                ws.Dispose();
                wb.Dispose();
            }
        }

        private void DataGridDeDespesas_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void DataGridDeDespesas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
