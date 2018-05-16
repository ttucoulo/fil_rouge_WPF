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
    /// Logique d'interaction pour WchA.xaml
    /// </summary>
    public partial class WchA : Window
    {
        Administration donnee;
        int matricule;
        public WchA(object e, int mat)
        {
            donnee = (Administration)e;
            matricule = mat;
            InitializeComponent();
        }
        private void ValidClick(object sender, RoutedEventArgs e)
        {

            int index_monstre = donnee.ReturnIndexList(matricule, true);
            int nouvelle_affectation = int.Parse(NouvA.Text);
            int compteur = 0;
            for (int k = 0; k < donnee.Attractions.Count; k++)
            {
                if (donnee.Attractions[k].Id == nouvelle_affectation)
                {
                    compteur++;
                }
            }
            if(compteur==0)
            {
                MessageBox.Show("affectation non existante");
            }
            else
            {
                for (int i = 0; i < donnee.ToutLePersonnel.Count(); i++)
                {
                    if (i == index_monstre)
                    {

                        ((Monstre)donnee.ToutLePersonnel[i]).Affectation = nouvelle_affectation;
                        //modifier la l equipe de l attrqction
                        MessageBox.Show("modification faite");
                    }


                }
            }
            
        }
    }
}
