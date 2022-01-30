using System.Windows.Controls;
using Microsoft.Win32;

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

        private void ExplorerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog exp = new OpenFileDialog();
            exp.Multiselect = false;
            exp.Filter = "TXT (*.txt)|*.txt|CSV (*.csv)|*.csv|Todos (*.*)|*.*";
            exp.Title = "Seleccionar archivo";
            if (exp.ShowDialog() == true)
                PathTxt.Text = exp.FileName;
        }
    }
}
