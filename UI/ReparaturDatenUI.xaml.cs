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

            // Reparaturen-Liste ins Grid laden
            this.dataGridReparaturDaten.DataContext = getReparaturen();

            // per Default leeres Reparatur-Objekt laden
            this.gridReparaturDaten.DataContext = new Model.T_REPARATUR();

            // Arbeitliste ins Grid laden
            this.dataGridArbeit.DataContext = getArbeitliste();

            // Materialliste mit leere Liste initialisieren, da momentan keine Daten in DB
            this.dataGridMaterial.DataContext = new List<Model.TZ_MATERIALLISTE>();
        }

        /// <summary>
        /// Liefert alle Arbeitslisten
        /// </summary>
        /// <returns>Arbeitsliste</returns>
        private List<Model.TZ_ARBEITLISTE> getArbeitliste()
        {
            List<Model.TZ_ARBEITLISTE> arbeitliste; // = new List<Model.T_FAHRZEUG>();
            using (Model.Context context = new Model.Context())
            {
                // Fahrzeuge holen
                arbeitliste = context.TZ_ARBEITLISTE.ToList();

                // Entitäten laden
                arbeitliste.Where(q => q.TR_ARBEITReference != null).ToList().ForEach(q => q.TR_ARBEITReference.Load());
            }
            return arbeitliste.ToList();
        }

        /// <summary>
        /// Liefert alle Reparaturen
        /// </summary>
        /// <returns>Reparaturenliste</returns>
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

            List<Model.TZ_ARBEITLISTE> al = this.dataGridArbeit.DataContext as List<Model.TZ_ARBEITLISTE>;

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
                            foreach (Model.TZ_ARBEITLISTE arbl in al)
                            {
                                if (arbl.ABL_ID > 0)
                                {
                                    context.ApplyCurrentValues<Model.TZ_ARBEITLISTE>("TZ_ARBEITLISTE", arbl);
                                }
                                else
                                {
                                    context.AddToTZ_ARBEITLISTE(arbl);
                                }
                            }
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
