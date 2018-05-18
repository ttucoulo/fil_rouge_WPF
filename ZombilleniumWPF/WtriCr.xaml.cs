using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZombilleniumWPF
{
    /// <summary>
    /// Logique d'interaction pour WtriCr.xaml
    /// </summary>
    public partial class WtriCr : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public WtriCr(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<LoupGarou> liste_loup_garou = new List<LoupGarou>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is LoupGarou) liste_loup_garou.Add((LoupGarou)donnee.ToutLePersonnel[i]);
            }
            liste_loup_garou.Sort();
            Liste_cruaute = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Monstre> liste = new List<Monstre>();
            for (int i = 0; i < liste_loup_garou.Count; i++)
            {
                liste.Add(liste_loup_garou[i]);
            }
            Liste_cruaute.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
