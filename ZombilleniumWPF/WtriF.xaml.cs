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
    /// Logique d'interaction pour WtriF.xaml
    /// </summary>
    public partial class WtriF : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public WtriF(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<Demon> liste_demon = new List<Demon>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Demon) liste_demon.Add((Demon)donnee.ToutLePersonnel[i]);
            }
            liste_demon.Sort();
            Liste_force = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Monstre> liste = new List<Monstre>();
            for (int i = 0; i < liste_demon.Count; i++)
            {
                liste.Add(liste_demon[i]);
            }
            Liste_force.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
