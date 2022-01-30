using DANE_Reports.model;
using DANE_Reports.ui;
using System;
using System.Windows;

namespace DANE_Reports
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DANEData Manager;

        public MainWindow()
        {
            InitializeComponent();
            Manager = new DANEData();
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Uri("ui/ImportScreen.xaml", UriKind.Relative), Manager);
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Uri("ui/SearchScreen.xaml", UriKind.Relative), Manager);
        }

        private void TableBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GraphBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
