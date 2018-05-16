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
    /// Logique d'interaction pour WchF.xaml
    /// </summary>
    public partial class WchF : Window
    {
        Administration donnee;
        int matricule;
        public WchF(object e, int mat)
        {
            donnee = (Administration)e;
            matricule = mat;
            InitializeComponent();
        }
        private void ValidClick(object sender, RoutedEventArgs e)
        {
            
            int index_monstre = donnee.ReturnIndexList(matricule, true);
            string nouvelle_fonction = NouvFonc.Text;
            for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
            {
                    if (i == index_monstre)
                    {
                        ((Monstre)donnee.ToutLePersonnel[i]).Fonction =nouvelle_fonction;
                        MessageBox.Show("modification faite");
                    }

                
            }
        }
    }
}
