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
            cbRegion.Items.Add(new Region("FR-ARA", "Auvergne-Rhône-Alpes"));
            cbRegion.Items.Add(new Region("FR-BFC", "Bourgogne-Franche-Comté"));
            cbRegion.Items.Add(new Region("FR-BRE", "Bretagne"));
            cbRegion.Items.Add(new Region("FR-CVL", "Centre-Val de Loire"));
            cbRegion.Items.Add(new Region("FR-COR", "Corse"));
            cbRegion.Items.Add(new Region("FR-GES", "Grand Est"));
            cbRegion.Items.Add(new Region("FR- HDF", "Hauts-de-France"));
            cbRegion.Items.Add(new Region("FR-IDF", "Île-de-France"));
            cbRegion.Items.Add(new Region("FR-NOR", "Normandie"));
            cbRegion.Items.Add(new Region("FR-NAQ", "Nouvelle-Aquitaine"));
            cbRegion.Items.Add(new Region("FR-OCC", "Occitanie"));
            cbRegion.Items.Add(new Region("FR-PDL", "Pays de la Loire"));
            cbRegion.Items.Add(new Region("FR-PAC", "Provence-Alpes-Côte d'Azur"));
        }
       
        private void cbRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = cbRegion.SelectedItem;
            String code = item.GetType().GetProperty("code").GetValue(item).ToString();
            MessageBox.Show(code);
        }
    }
}

class Region
{
    public Region(String code, String nom)
    {
        this.code = code;
        this.nom = nom;
    }
    public String code { get; set; }
    public String nom { get; set; }
}

