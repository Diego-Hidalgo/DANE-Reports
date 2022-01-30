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

        internal DANEData Manager { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Manager = new DANEData();
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            ImportScreen importScreen = new ImportScreen
            {
                Manager = Manager
            };
            MyFrame.Navigate(importScreen);

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen
            {
                Manager = Manager
            };
            MyFrame.Navigate(searchScreen);
        }

        private void TableBtn_Click(object sender, RoutedEventArgs e)
        {
            TableScreen tableScreen = new TableScreen
            {
                Manager = Manager
            };
            MyFrame.Navigate(tableScreen);
        }

        private void GraphBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
