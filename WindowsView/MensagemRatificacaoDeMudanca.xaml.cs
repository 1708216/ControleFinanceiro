using System;
using System.Windows;


namespace WindowsView
{
    /// <summary>
    /// Interaction logic for MensagemRatificacaoDeMudanca.xaml
    /// </summary>
    public partial class MensagemRatificacaoDeMudanca : Window
    {
        Boolean retornoOpcao;

        public MensagemRatificacaoDeMudanca()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {
            retornoOpcao = true;
            Close();
        }
        private void btnNao_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public Boolean RetornarOpcaoExlcuirOperacao()
        {
            return retornoOpcao;
        }
    }
}
