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
    /// Interaction logic for NutzerDatenUI.xaml
    /// </summary>
    public partial class NutzerDatenUI : Window
    {
        public NutzerDatenUI()
        {
            InitializeComponent();

            this.dataGridNutzerDaten.DataContext = getNutzer();

            // Nutzer Details Maske mit neuem Nutzer binden
            this.gridNutzerDaten.DataContext = new Model.T_NUTZER();
        }

        /// <summary>
        /// Gibt alle Nutzer zurück
        /// </summary>
        /// <returns>Liste der Nutzer</returns>
        private List<Model.T_NUTZER> getNutzer()
        {
            List<Model.T_NUTZER> nutzer = new List<Model.T_NUTZER>();
            using(Model.Context context = new Model.Context())
            {
                nutzer = context.T_NUTZER.ToList();
            }
            return nutzer;
        }

        /// <summary>
        /// Gibt alle Nutzer zurück
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Liste aller Nutzer</param>
        private void dataGridNutzerDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.T_NUTZER selectedItem = this.dataGridNutzerDaten.SelectedItem as Model.T_NUTZER;

            if (selectedItem != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    this.gridNutzerDaten.DataContext = context.T_NUTZER.Where(q => q.NUT_ID == selectedItem.NUT_ID).First();
                }
            }
        }

        /// <summary>
        /// Erstellt einen neuen Nutzer im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            this.gridNutzerDaten.DataContext = new Model.T_NUTZER();
        }

        /// <summary>
        /// Löscht einen Nutzer aus dem Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.T_NUTZER currentNutzer = this.gridNutzerDaten.DataContext as Model.T_NUTZER;

            if (currentNutzer != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.T_NUTZER nutzerToDelete = context.T_NUTZER.Where(q => q.NUT_ID == currentNutzer.NUT_ID).First();

                    if (nutzerToDelete != null)
                    {
                        context.T_NUTZER.DeleteObject(context.T_NUTZER.Where(q => q.NUT_ID == nutzerToDelete.NUT_ID).First());
                        context.SaveChanges();
                    }
                }
                this.gridNutzerDaten.DataContext = new Model.T_NUTZER();
                this.dataGridNutzerDaten.DataContext = getNutzer();
            }
        }

        /// <summary>
        /// Speichert Änderungen eines Nutzerdatensatzes im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Model.T_NUTZER currentNutzer = this.gridNutzerDaten.DataContext as Model.T_NUTZER;

            if (currentNutzer != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.T_NUTZER nutzerToSave;

                    if (!currentNutzer.isNew)
                    {
                        nutzerToSave = context.T_NUTZER.Where(q => q.NUT_ID == currentNutzer.NUT_ID).First();

                        if (nutzerToSave != null)
                        {
                            context.ApplyCurrentValues<Model.T_NUTZER>("T_NUTZER", currentNutzer);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        context.AddToT_NUTZER(currentNutzer);
                        context.SaveChanges();
                    }
                }

                this.dataGridNutzerDaten.DataContext = getNutzer();
            }
        }
    }
}
