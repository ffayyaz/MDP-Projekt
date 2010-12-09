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
    /// Interaction logic for FahrzeugDaten.xaml
    /// </summary>
    public partial class FahrzeugDatenUI : Window
    {
        public FahrzeugDatenUI()
        {
            InitializeComponent();

            // Fahrzeugdaten in Fahrzeugdaten Grid laden
            this.gridFahrzeugDaten.DataContext = getFahrzeuge();

            // ComboBox Fahrzeugart abfüllen
            this.comboFahrzeugArt.ItemsSource = getFahrzeugarten();
            this.comboFahrzeugArt.DisplayMemberPath = "FZA_BEZEICHNUNG";
            this.comboFahrzeugArt.SelectedValuePath = "FZA_ID";
        }

        /// <summary>
        /// Gibt alle Fahrzeuge zurück
        /// </summary>
        /// <returns>Liste der Fahrzeuge</returns>
        private List<Model.T_FAHRZEUG> getFahrzeuge()
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

        /// <summary>
        /// Gibt alle Fahrzeugarten zurück
        /// </summary>
        /// <returns>Liste der Fahrzeugarten</returns>
        private List<Model.TR_FAHRZEUGART> getFahrzeugarten()
        {
            List<Model.TR_FAHRZEUGART> arten = new List<Model.TR_FAHRZEUGART>();
            using (Model.Context context = new Model.Context())
            {
                arten = context.TR_FAHRZEUGART.ToList();
            }

            return arten;
        }

        private void gridFahrzeugDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.T_FAHRZEUG selectedItem = this.gridFahrzeugDaten.SelectedItem as Model.T_FAHRZEUG;

            if (selectedItem != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    this.viewFahrzeug.DataContext = context.T_FAHRZEUG.Where(q => q.FZG_ID == selectedItem.FZG_ID).First();
                }
            }
        }

    }
}
