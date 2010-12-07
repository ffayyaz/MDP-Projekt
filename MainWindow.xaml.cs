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
                // Create example 1
                context.AddToT_NUTZER(new Model.T_NUTZER() { NUT_NAME = "Selim", NUT_ORT = "Zug", NUT_PLZ = 6300 });
                context.SaveChanges();

                // Create example 2
                Model.TZ_FAHRZEUGMARKE marketyp = new Model.TZ_FAHRZEUGMARKE();
                marketyp.TR_FAHRZEUGTYP = new Model.TR_FAHRZEUGTYP() { FZT_BEZEICHNUNG = "Piaggio" };
                marketyp.FZM_BEZEICHNUNG = "MSX 323 Turbo";
                context.AddToTZ_FAHRZEUGMARKE(marketyp);
                context.SaveChanges();

                // Update example
                Model.T_NUTZER nutzer = context.T_NUTZER.Where(q => q.NUT_ID == 1).First();
                nutzer.NUT_NAME = "Noëlle";
                context.SaveChanges();

                // Delete example
                context.T_NUTZER.DeleteObject(context.T_NUTZER.Where(q => q.NUT_ID == 5).First());
                context.SaveChanges();
            }
        }
    }
}
