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

            this.gridReparaturDaten.DataContext = getReparaturen();
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
    }
}
