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
    /// Interaction logic for MaterialDatenUI.xaml
    /// </summary>
    public partial class MaterialDatenUI : Window
    {
        public MaterialDatenUI()
        {
            InitializeComponent();
            this.dataGridMaterialDaten.DataContext = getMaterial();
        }

        /// <summary>
        /// Gibt alles Material zurück
        /// </summary>
        /// <returns>Liste des Materials</returns>
        private List<Model.TR_MATERIAL> getMaterial()
        {
            List<Model.TR_MATERIAL> material = new List<Model.TR_MATERIAL>();
            using(Model.Context context = new Model.Context())
            {
                material = context.TR_MATERIAL.ToList();
            }
            return material;
        }

        /// <summary>
        /// Gibt alle Materialien zurück
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Liste aller Materialien</param>
        private void dataGridMaterialDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.TR_MATERIAL selectedItem = this.dataGridMaterialDaten.SelectedItem as Model.TR_MATERIAL;

            if (selectedItem != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    this.gridMaterialDaten.DataContext = context.TR_MATERIAL.Where(q => q.MAT_ID == selectedItem.MAT_ID).First();
                }
            }
        }
    }
}
