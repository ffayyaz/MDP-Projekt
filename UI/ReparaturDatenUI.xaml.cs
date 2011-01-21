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

namespace MDP_Projekt.UI
{
    /// <summary>
    /// Interaction logic for RechnungsDatenUI.xaml
    /// </summary>
    public partial class RechnungsDatenUI : Page
    {
        public RechnungsDatenUI()
        {
            InitializeComponent();

            this.dataGridReparaturDaten.DataContext = getReparaturen();

            this.gridReparaturDaten.DataContext = new Model.T_REPARATUR();
        }

        private List<Model.T_REPARATUR> getReparaturen()
        {
            List<Model.T_REPARATUR> reparaturen; // = new List<Model.T_FAHRZEUG>();
            using (Model.Context context = new Model.Context())
            {
                // Fahrzeuge holen
                reparaturen = context.T_REPARATUR.ToList();

                // ... deren Entitäten laden
                reparaturen.Where(q => q.T_FAHRZEUGReference != null).ToList().ForEach(q => q.T_FAHRZEUGReference.Load());
            }
            return reparaturen.ToList();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            this.gridReparaturDaten.DataContext = new Model.T_REPARATUR();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Model.T_REPARATUR currentReparatur = this.gridReparaturDaten.DataContext as Model.T_REPARATUR;

            if (currentReparatur != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.T_REPARATUR reparaturToSave;

                    if (!currentReparatur.isNew)
                    {
                        reparaturToSave = context.T_REPARATUR.Where(q => q.REP_ID == currentReparatur.REP_ID).FirstOrDefault();

                        if (reparaturToSave != null)
                        {
                            context.ApplyCurrentValues<Model.T_REPARATUR>("T_REPARATUR", currentReparatur);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        context.AddToT_REPARATUR(currentReparatur);
                        context.SaveChanges();
                    }
                }

                this.dataGridReparaturDaten.DataContext = getReparaturen();
            }
        }
    }
}
