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

        private void showFahrzeugDaten(object sender, RoutedEventArgs e)
        {
            frmPage.Navigate(new System.Uri("UI/FahrzeugDatenUI.xaml", UriKind.RelativeOrAbsolute));
        }

        private void showNutzerDaten(object sender, RoutedEventArgs e)
        {
            frmPage.Navigate(new System.Uri("UI/NutzerDatenUI.xaml", UriKind.RelativeOrAbsolute));
        }

        private void showMaterialDaten(object sender, RoutedEventArgs e)
        {
            frmPage.Navigate(new System.Uri("UI/MaterialDatenUI.xaml", UriKind.RelativeOrAbsolute));
        }

        private void showArbeitsDaten(object sender, RoutedEventArgs e)
        {
            frmPage.Navigate(new System.Uri("UI/ArbeitsDatenUI.xaml", UriKind.RelativeOrAbsolute));
        }

        private void showUnknown(object sender, RoutedEventArgs e)
        {
            canvasUnknown.Visibility = Visibility.Visible;

            // ...
        }
    }
}
