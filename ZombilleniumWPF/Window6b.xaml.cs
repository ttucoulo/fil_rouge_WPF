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
    /// Logique d'interaction pour Window6b.xaml
    /// </summary>
    public partial class Window6b : Window
    {
        Administration donnee;
        int matricule;
        public Window6b(object e, int mat)
        {
            matricule = mat;
            donnee = (Administration)e;
            InitializeComponent();
        }
        private void ValidClick(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(cagnotte.Text);
            int index_monstre = donnee.ReturnIndexList(matricule, true);
            int nombreCagnotte = int.Parse(cagnotte.Text);
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                if (donnee.ToutLePersonnel[i] is Monstre)
                {
                    if (i == index_monstre)
                    {
                        ((Monstre)donnee.ToutLePersonnel[i]).ModifierCagnotte(((Monstre)donnee.ToutLePersonnel[index_monstre]), nombreCagnotte);
                        MessageBox.Show("modification faite");
                    }
                    
                }
            }
        }
    }
}
