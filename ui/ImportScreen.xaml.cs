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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DANE_Reports.ui
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class ImportScreen : Page
    {
        public ImportScreen()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("IT WORKS!!!");
        }
    }
}