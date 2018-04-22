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

            }
            catch (FormatException)
            {

            }
        }
    }
}
