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

namespace AnonymousDemo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            cbRegion.DisplayMemberPath = "nom";
            cbRegion.SelectedValuePath = "code";
            cbRegion.Items.Add(new { code = "FR-ARA", nom = "Auvergne-Rhône-Alpes" });
            cbRegion.Items.Add(new { code = "FR-BFC", nom = "Bourgogne-Franche-Comté" });
            cbRegion.Items.Add(new { code = "FR-BRE", nom = "Bretagne" });
            cbRegion.Items.Add(new { code = "FR-CVL", nom = "Centre-Val de Loire" });
            cbRegion.Items.Add(new { code = "FR-COR", nom = "Corse" });
            cbRegion.Items.Add(new { code = "FR-GES", nom = "Grand-Est" });
            cbRegion.Items.Add(new { code = "FR-IDF", nom = "Île-de-France" });
            cbRegion.Items.Add(new { code = "FR-NOR", nom = "Normandie" });
            cbRegion.Items.Add(new { code = "FR-NAQ", nom = "Nouvelle-Aquitaine" });
            cbRegion.Items.Add(new { code = "FR-OCC", nom = "Occitanie" });
            cbRegion.Items.Add(new { code = "FR-PDL", nom = "Pays-de-la-Loire" });
            cbRegion.Items.Add(new { code = "FR-PAC", nom = "Provence-Alpes-Côte-d'Azur" });
        }

        private void cbRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = cbRegion.SelectedItem;
            String code = item.GetType().GetProperty("code").GetValue(item).ToString();
            MessageBox.Show(code);
        }
    }
}