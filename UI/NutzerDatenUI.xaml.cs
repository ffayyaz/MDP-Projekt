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


    }
}
