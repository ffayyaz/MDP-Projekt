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
    /// Interaction logic for ArbeitsDatenGUI.xaml
    /// </summary>
    public partial class ArbeitsDatenGUI : Page
    {
        public ArbeitsDatenGUI()
        {
            InitializeComponent();

            this.dataGridArbeitsDaten.DataContext = getArbeit();

            // Tätigkeiten Details Maske mit neuen Tätigkeiten binden
            this.gridArbeitsDaten.DataContext = new Model.TR_ARBEIT();
        }

                /// <summary>
        /// Gibt alle Tätigkeiten zurück
        /// </summary>
        /// <returns>Liste der Tätigkeiten</returns>
        private List<Model.TR_ARBEIT> getArbeit()
        {
            List<Model.TR_ARBEIT> arbeit = new List<Model.TR_ARBEIT>();
            using(Model.Context context = new Model.Context())
            {
                arbeit = context.TR_ARBEIT.ToList();
            }
            return arbeit;
        }

        /// <summary>
        /// Gibt alle Tätigkeiten zurück
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Liste aller Tätigkeiten</param>
        private void dataGridArbeitsDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.TR_ARBEIT selectedItem = this.dataGridArbeitsDaten.SelectedItem as Model.TR_ARBEIT;

            if (selectedItem != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    this.gridArbeitsDaten.DataContext = context.TR_ARBEIT.Where(q => q.ARB_ID == selectedItem.ARB_ID).First();
                }
            }
        }

        /// <summary>
        /// Erstellt eine neue Tätigkeit im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            this.gridArbeitsDaten.DataContext = new Model.TR_ARBEIT();
        }

        /// <summary>
        /// Löscht eine Tätigkeit aus dem Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.TR_ARBEIT currentArbeit = this.gridArbeitsDaten.DataContext as Model.TR_ARBEIT;

            if (currentArbeit != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.TR_ARBEIT arbeitToDelete = context.TR_ARBEIT.Where(q => q.ARB_ID == currentArbeit.ARB_ID).First();

                    if (arbeitToDelete != null)
                    {
                        context.TR_ARBEIT.DeleteObject(context.TR_ARBEIT.Where(q => q.ARB_ID == arbeitToDelete.ARB_ID).First());
                        context.SaveChanges();
                    }
                }
                this.gridArbeitsDaten.DataContext = new Model.TR_MATERIAL();
                this.dataGridArbeitsDaten.DataContext = getArbeit();
            }
        }

        /// <summary>
        ///  Speichert eine neue Tätigkeit im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Model.TR_ARBEIT currentArbeit = this.gridArbeitsDaten.DataContext as Model.TR_ARBEIT;

            if (currentArbeit != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.TR_ARBEIT arbeitToSave;

                    if (!currentArbeit.isNew)
                    {
                        arbeitToSave = context.TR_ARBEIT.Where(q => q.ARB_ID == currentArbeit.ARB_ID).First();

                        if (arbeitToSave != null)
                        {
                            context.ApplyCurrentValues<Model.TR_ARBEIT>("TR_ARBEIT", currentArbeit);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        context.AddToTR_ARBEIT(currentArbeit);
                        context.SaveChanges();
                    }
                }

                this.dataGridArbeitsDaten.DataContext = getArbeit();
            }
        }
    }
}
