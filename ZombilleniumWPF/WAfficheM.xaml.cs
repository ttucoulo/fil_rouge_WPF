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
    /// Logique d'interaction pour WAfficheM.xaml
    /// </summary>
    public partial class WAfficheM : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public WAfficheM(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<Monstre> liste_monstre = new List<Monstre>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Monstre) liste_monstre.Add((Monstre)donnee.ToutLePersonnel[i]);
            }
            Liste_monstres = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Monstre> liste = new List<Monstre>();
            for (int i = 0; i < liste_monstre.Count; i++)
            {
                liste.Add(liste_monstre[i]);
            }
            Liste_monstres.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
