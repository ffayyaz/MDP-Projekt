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

            this.gridNutzerDaten.ItemsSource = getNutzer();

            this.comboNutzer.ItemsSource = getNutzer();
            this.comboNutzer.DisplayMemberPath = "NUT_NAME";
            this.comboNutzer.SelectedValuePath = "NUT_ID";
        }

        private List<Model.T_NUTZER> getNutzer()
        {
            List<Model.T_NUTZER> nutzer = new List<Model.T_NUTZER>();
            using(Model.Context context = new Model.Context())
            {
                nutzer = context.T_NUTZER.ToList();
            }
            return nutzer;
        }
    }
}
