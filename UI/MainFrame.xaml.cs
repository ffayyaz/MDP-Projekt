using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace MDP_Projekt.UI
{
    /// <summary>
    /// Interaction logic for MainFrame.xaml
    /// </summary>
    public partial class MainFrame : Window
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnknownClose_Click(object sender, RoutedEventArgs e)
        {
            hideAll();
        }

        private void hideAll()
        {
            canvasUnknown.Visibility = Visibility.Hidden;

            // ...
        }

        private void showFahrzeugDaten(object sender, RoutedEventArgs e)
        {
            UI.FahrzeugDatenUI fahrzeugGUI = new UI.FahrzeugDatenUI();
            fahrzeugGUI.ShowDialog();
        }

        private void showNutzerDaten(object sender, RoutedEventArgs e)
        {
            UI.NutzerDatenUI nutzerGUI = new UI.NutzerDatenUI();
            nutzerGUI.ShowDialog();
        }

        private void showMaterialDaten(object sender, RoutedEventArgs e)
        {
            UI.MaterialDatenUI materialienGUI = new UI.MaterialDatenUI();
            materialienGUI.ShowDialog();
        }

        private void showUnknown(object sender, RoutedEventArgs e)
        {
            canvasUnknown.Visibility = Visibility.Visible;

            // ...
        }
    }
}
