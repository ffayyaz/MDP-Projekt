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

namespace MDP_Projekt.UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private List<Model.T_FAHRZEUG> LoadCollectionData()
        {
            List<Model.T_FAHRZEUG> fahrzeuge = new List<Model.T_FAHRZEUG>();
            using (Model.Context context = new Model.Context())
            {
                // Fahrzeuge holen
                fahrzeuge = context.T_FAHRZEUG.ToList();

                // ... deren Entitäten laden
                fahrzeuge.ForEach(q => q.TZ_FAHRZEUGMARKEReference.Load());
                fahrzeuge.ForEach(q => q.TR_FAHRZEUGARTReference.Load());
                fahrzeuge.ForEach(q => q.T_NUTZERReference.Load());
                fahrzeuge.ForEach(q => q.TZ_FAHRZEUGMARKE.TR_FAHRZEUGTYPReference.Load());
            }
            return fahrzeuge;

        } 
        private void FahrzeugDaten_Loaded(object sender, RoutedEventArgs e)
        {
            gridFahrzeugDaten.ItemsSource = LoadCollectionData();
        }
    }
}
