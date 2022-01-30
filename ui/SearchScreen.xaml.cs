using DANE_Reports.model;
using System.Windows.Controls;
using System.Windows;

namespace DANE_Reports.ui
{
    /// <summary>
    /// Lógica de interacción para SearchScreen.xaml
    /// </summary>
    public partial class SearchScreen : Page
    {

        internal DANEData Manager { get; set; }

        public SearchScreen()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string id = IdTxt.Text;
            if(string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Debe llenar el campo.");
                return;
            }
            ClearLabels();
            Data found = Manager.FindCityById(id);
            if(found == null)
            {
                MessageBox.Show("No se encontró el id: " + id);
                return;
            }
            StateIdLbl.Content = found.StateId;
            StateNameLbl.Content = found.StateName;
            CityIdLbl.Content = found.CityId;
            CityNameLbl.Content = found.CityName;
            TypeLbl.Content = found.CityType;
            IdTxt.Text = "";
        }

        private void ClearLabels()
        {
            StateIdLbl.Content = "";
            StateNameLbl.Content = "";
            CityIdLbl.Content = "";
            CityNameLbl.Content = "";
            TypeLbl.Content = "";
        }

    }
}
