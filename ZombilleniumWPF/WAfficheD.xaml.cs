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
    /// Logique d'interaction pour WAfficheD.xaml
    /// </summary>
    public partial class WAfficheD : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public WAfficheD(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<Demon> liste_demon = new List<Demon>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Demon) liste_demon.Add((Demon)donnee.ToutLePersonnel[i]);
            }
            Liste_demons = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Demon> liste = new List<Demon>();
            for (int i = 0; i < liste_demon.Count; i++)
            {
                liste.Add(liste_demon[i]);
            }
            Liste_demons.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
