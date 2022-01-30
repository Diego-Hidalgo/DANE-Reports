using DANE_Reports.model;
using System.Windows.Controls;
using System.Windows;

namespace DANE_Reports.ui
{
    /// <summary>
    /// Lógica de interacción para TableScreen.xaml
    /// </summary>
    public partial class TableScreen : Page
    {
        internal DANEData Manager { get; set; }
        public TableScreen()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tableData.ItemsSource = Manager.Data;
        }
    }
}
