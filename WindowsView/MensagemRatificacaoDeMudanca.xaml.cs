﻿using System;
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
