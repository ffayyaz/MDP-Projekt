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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDP_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            testButton.Content = "hallo Welt";

            // Beispiel Code
            using (Model.Context context = new Model.Context())
            {
                context.AddToT_NUTZER(new Model.T_NUTZER() { NUT_NAME = "Selim", NUT_ORT = "Zug", NUT_PLZ = 6300 });
                context.SaveChanges();
            }
        }
    }
}
