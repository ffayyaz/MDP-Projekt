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
            this.gridFahrzeugDaten.ItemsSource = LoadCollectionData();

            // ComboBox Fahrzeugart abfüllen
            this.comboFahrzeugArt.ItemsSource = LoadFahrzeugartCombo();
            this.comboFahrzeugArt.DisplayMemberPath = "FZA_BEZEICHNUNG";
            this.comboFahrzeugArt.SelectedValuePath = "FZA_ID";
        }

        private List<Model.T_FAHRZEUG> LoadCollectionData()
        {
            List<Model.T_FAHRZEUG> fahrzeuge = new List<Model.T_FAHRZEUG>();
            using (Model.Context context = new Model.Context())
            {
                fahrzeuge = context.T_FAHRZEUG.ToList();
            }
            return fahrzeuge;
        }

        private List<Model.TR_FAHRZEUGART> LoadFahrzeugartCombo()
        {
            List<Model.TR_FAHRZEUGART> arten = new List<Model.TR_FAHRZEUGART>();
            using (Model.Context context = new Model.Context())
            {
                arten = context.TR_FAHRZEUGART.ToList();
            }

            return arten;
        }

    }
}
