﻿using DANE_Reports.ui;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DANE_Reports
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Import Clicked");
            MyFrame.NavigationService.Navigate(new Uri("ui/ImportScreen.xaml", UriKind.Relative));
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TableBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Uri("ui/TableScreen.xaml", UriKind.Relative));
        }

        private void GraphBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
