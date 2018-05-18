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
    /// Logique d'interaction pour Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Administration donnee;
        // public ObservableCollection<object> liste { get; set; }
        public Window3(object e)
        {
            this.DataContext = donnee;
            donnee = (Administration)e;
            List<Sorcier> liste_sorcier = new List<Sorcier>();
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Sorcier) liste_sorcier.Add((Sorcier)donnee.ToutLePersonnel[i]);
            }
            Liste_sorciers = new ListView();
            // liste = new ObservableCollection<object>();
            // liste.Cast<Monstre>();
            List<Sorcier> liste = new List<Sorcier>();
            for (int i = 0; i < liste_sorcier.Count; i++)
            {
                liste.Add(liste_sorcier[i]);
            }
            Liste_sorciers.ItemsSource = liste;
            //liste.Add(liste_monstre);

            InitializeComponent();
        }
    }
}
