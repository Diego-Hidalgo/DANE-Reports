using System.Threading;
using System.Windows;
using System.Windows.Controls;
using DANE_Reports.model;
using Microsoft.Win32;

namespace DANE_Reports.ui
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class ImportScreen : Page
    {

        internal DANEData Manager { get; set; }

        public ImportScreen()
        {
            InitializeComponent();
        }

        private void ExplorerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog exp = new OpenFileDialog();
            exp.Multiselect = false;
            exp.Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt|Todos (*.*)|*.*";
            exp.Title = "Seleccionar archivo";
            if (exp.ShowDialog() == true)
                PathTxt.Text = exp.FileName;
        }

        private void ImpData_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string path = PathTxt.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Deben llenarse todos los espacios.");
                return;
            }
            char sep = char.Parse(SeparatorTxt.Text);
            bool header = (Y.IsChecked == true);
            new Thread(() =>
            {
                Manager.ImportFileData(path, sep, header);
                MessageBox.Show("Se han importado los datos.");
            }).Start();
        }
    }
}
