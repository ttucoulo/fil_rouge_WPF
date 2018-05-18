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
    /// Logique d'interaction pour WtriL.xaml
    /// </summary>
    public partial class WtriL : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public WtriL(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<Vampire> liste_vampire = new List<Vampire>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Vampire) liste_vampire.Add((Vampire)donnee.ToutLePersonnel[i]);
            }
            liste_vampire.Sort();
            Liste_luminosite = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Monstre> liste = new List<Monstre>();
            for (int i = 0; i < liste_vampire.Count; i++)
            {
                liste.Add(liste_vampire[i]);
            }
            Liste_luminosite.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
