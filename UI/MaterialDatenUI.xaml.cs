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

            // Material Details Maske mit neuem Material binden
            this.gridMaterialDaten.DataContext = new Model.TR_MATERIAL();
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

        /// <summary>
        /// Erstellt ein neues Material im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            this.gridMaterialDaten.DataContext = new Model.TR_MATERIAL();
        }

        /// <summary>
        /// Löscht ein Material aus dem Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.TR_MATERIAL currentMaterial = this.gridMaterialDaten.DataContext as Model.TR_MATERIAL;

            if (currentMaterial != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.TR_MATERIAL materialToDelete = context.TR_MATERIAL.Where(q => q.MAT_ID == currentMaterial.MAT_ID).First();

                    if (materialToDelete != null)
                    {
                        context.TR_MATERIAL.DeleteObject(context.TR_MATERIAL.Where(q => q.MAT_ID == materialToDelete.MAT_ID).First());
                        context.SaveChanges();
                    }
                }
                this.gridMaterialDaten.DataContext = new Model.TR_MATERIAL();
                this.dataGridMaterialDaten.DataContext = getMaterial();
            }
        }

        /// <summary>
        ///  Speichert ein neues Material im Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Model.TR_MATERIAL currentMaterial = this.gridMaterialDaten.DataContext as Model.TR_MATERIAL;

            if (currentMaterial != null)
            {
                using (Model.Context context = new Model.Context())
                {
                    Model.TR_MATERIAL materialToSave;

                    if (currentMaterial.isNew)
                    {
                        materialToSave = context.TR_MATERIAL.Where(q => q.MAT_ID == currentMaterial.MAT_ID).First();

                        if (materialToSave != null)
                        {
                            context.ApplyCurrentValues<Model.TR_MATERIAL>("TR_MATERIAL", currentMaterial);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        context.AddToTR_MATERIAL(currentMaterial);
                        context.SaveChanges();
                    }
                }

                this.dataGridMaterialDaten.DataContext = getMaterial();
            }
        }
    }
}
