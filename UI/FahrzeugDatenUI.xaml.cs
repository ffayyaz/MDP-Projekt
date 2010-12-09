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
            this.comboFahrzeugArt.SelectedValue = 1;

            // ComboBox Fahrzeugmarke abfüllen
            this.comboFahrzeugMarke.ItemsSource = LoadFahrzeugmarkeCombo();
            this.comboFahrzeugMarke.DisplayMemberPath = "FZM_BEZEICHNUNG";
            this.comboFahrzeugMarke.SelectedValuePath = "FZM_ID";
            this.comboFahrzeugMarke.SelectedValue = 1;

            // ComboBox Fahrzeugtyp abfüllen
            this.comboFahrzeugTyp.ItemsSource = LoadFahrzeugtypCombo();
            this.comboFahrzeugTyp.DisplayMemberPath = "FZT_BEZEICHNUNG";
            this.comboFahrzeugTyp.SelectedValuePath = "FZT_ID";
            this.comboFahrzeugTyp.SelectedValue = 1;

            // ComboBox Nutzer abfüllen
            this.comboFahrzeugNutzer.ItemsSource = LoadFahrzeugnutzerCombo();
            this.comboFahrzeugNutzer.DisplayMemberPath = "NUT_NAME";
            this.comboFahrzeugNutzer.SelectedValuePath = "NUT_ID";
            this.comboFahrzeugNutzer.SelectedValue = 1;

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

        private List<Model.TR_FAHRZEUGART> LoadFahrzeugartCombo()
        {
            List<Model.TR_FAHRZEUGART> arten = new List<Model.TR_FAHRZEUGART>();
            using (Model.Context context = new Model.Context())
            {
                arten = context.TR_FAHRZEUGART.ToList();
            }

            return arten;
        }

        private List<Model.TZ_FAHRZEUGMARKE> LoadFahrzeugmarkeCombo()
        {
            List<Model.TZ_FAHRZEUGMARKE> marken = new List<Model.TZ_FAHRZEUGMARKE>();
            using (Model.Context context = new Model.Context())
            {
                marken = context.TZ_FAHRZEUGMARKE.ToList();
            }

            return marken;
        }

        private List<Model.TR_FAHRZEUGTYP> LoadFahrzeugtypCombo()
        {
            List<Model.TR_FAHRZEUGTYP> typen = new List<Model.TR_FAHRZEUGTYP>();
            using (Model.Context context = new Model.Context())
            {
                typen = context.TR_FAHRZEUGTYP.ToList();
            }

            return typen;
        }

        private List<Model.T_NUTZER> LoadFahrzeugnutzerCombo()
        {
            List<Model.T_NUTZER> nutzer = new List<Model.T_NUTZER>();
            using (Model.Context context = new Model.Context())
            {
                nutzer = context.T_NUTZER.ToList();
            }

            return nutzer;
        }
    }
}
