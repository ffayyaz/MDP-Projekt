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
            this.datagridFahrzeugDaten.DataContext = getFahrzeuge();

            // ComboBox Fahrzeugart abfüllen
            this.comboFahrzeugArt.ItemsSource = getFahrzeugarten();
            this.comboFahrzeugArt.DisplayMemberPath = "FZA_BEZEICHNUNG";
            this.comboFahrzeugArt.SelectedValuePath = "FZA_ID";

            // ComboBox Fahrzeugmarke abfüllen
            this.comboFahrzeugMarke.ItemsSource = getFahrzeugmarkeCombo();
            this.comboFahrzeugMarke.DisplayMemberPath = "FZM_BEZEICHNUNG";
            this.comboFahrzeugMarke.SelectedValuePath = "FZM_ID";

            // ComboBox Fahrzeugtyp abfüllen
            this.comboFahrzeugTyp.ItemsSource = getFahrzeugtypCombo();
            this.comboFahrzeugTyp.DisplayMemberPath = "FZT_BEZEICHNUNG";
            this.comboFahrzeugTyp.SelectedValuePath = "FZT_ID";

            // ComboBox Nutzer abfüllen
            this.comboFahrzeugNutzer.ItemsSource = getFahrzeugnutzerCombo();
            this.comboFahrzeugNutzer.DisplayMemberPath = "NUT_NAME";
            this.comboFahrzeugNutzer.SelectedValuePath = "NUT_ID";
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
                /*
                fahrzeuge.ForEach(q => q.TZ_FAHRZEUGMARKEReference.Load());
                fahrzeuge.ForEach(q => q.TR_FAHRZEUGARTReference.Load());
                fahrzeuge.ForEach(q => q.T_NUTZERReference.Load());
                fahrzeuge.ForEach(q => q.TZ_FAHRZEUGMARKE.TR_FAHRZEUGTYPReference.Load());
                 * */
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

        /// <summary>
        /// Gibt alle Fahrzeugmarken zurück
        /// </summary>
        /// <returns>Liste der Fahrzeugmarken</returns>
        private List<Model.TZ_FAHRZEUGMARKE> getFahrzeugmarkeCombo()
        {
            List<Model.TZ_FAHRZEUGMARKE> marken = new List<Model.TZ_FAHRZEUGMARKE>();
            using (Model.Context context = new Model.Context())
            {
                marken = context.TZ_FAHRZEUGMARKE.ToList();
            }

            return marken;
        }

        /// <summary>
        /// Gibt alle Fahrzeugtypen zurück
        /// </summary>
        /// <returns>Liste der Fahrzeugtypen</returns>
        private List<Model.TR_FAHRZEUGTYP> getFahrzeugtypCombo()
        {
            List<Model.TR_FAHRZEUGTYP> typen = new List<Model.TR_FAHRZEUGTYP>();
            using (Model.Context context = new Model.Context())
            {
                typen = context.TR_FAHRZEUGTYP.ToList();
            }

            return typen;
        }

        /// <summary>
        /// Gibt alle Fahrzeugnutzer zurück
        /// </summary>
        /// <returns>Liste der Fahrzeugnutzer</returns>
        private List<Model.T_NUTZER> getFahrzeugnutzerCombo()
        {
            List<Model.T_NUTZER> nutzer = new List<Model.T_NUTZER>();
            using (Model.Context context = new Model.Context())
            {
                nutzer = context.T_NUTZER.ToList();
            }

            return nutzer;
        }

        /// <summary>
        /// Lädt die Detailansicht anhand der Datagridauswahl
        /// </summary>
        /// <param name="sender">Senderobjekt Datagrid</param>
        /// <param name="e">Argument des Senderobjekts</param>
        private void gridFahrzeugDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.T_FAHRZEUG selectedItem = this.datagridFahrzeugDaten.SelectedItem as Model.T_FAHRZEUG;

            if (selectedItem != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    this.gridFahrzeug.DataContext = context.T_FAHRZEUG.Where(q => q.FZG_ID == selectedItem.FZG_ID).First();
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Model.T_FAHRZEUG currentFahrzeug = this.gridFahrzeug.DataContext as Model.T_FAHRZEUG;

            if (currentFahrzeug != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.T_FAHRZEUG fahrzeugToSave;

                    if (currentFahrzeug.FZG_ID > 0)
                    {
                        fahrzeugToSave = context.T_FAHRZEUG.Where(q => q.FZG_ID == currentFahrzeug.FZG_ID).First();

                        if (fahrzeugToSave != null)
                        {
                            context.ApplyCurrentValues<Model.T_FAHRZEUG>("T_FAHRZEUG", currentFahrzeug);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        context.AddToT_FAHRZEUG(currentFahrzeug);
                        context.SaveChanges();
                    }
                }

                this.datagridFahrzeugDaten.DataContext = getFahrzeuge();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.T_FAHRZEUG currentFahrzeug = this.gridFahrzeug.DataContext as Model.T_FAHRZEUG;

            if (currentFahrzeug != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.T_FAHRZEUG fahrzeugToDelete = context.T_FAHRZEUG.Where(q => q.FZG_ID == currentFahrzeug.FZG_ID).First();

                    if (fahrzeugToDelete != null)
                    {
                        context.T_FAHRZEUG.DeleteObject(context.T_FAHRZEUG.Where(q=>q.FZG_ID == fahrzeugToDelete.FZG_ID).First());
                        context.SaveChanges();
                    }
                }
                this.datagridFahrzeugDaten.DataContext = getFahrzeuge();
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            this.gridFahrzeug.DataContext = new Model.T_FAHRZEUG();
        }
    }
}
