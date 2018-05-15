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
    /// Logique d'interaction pour Wdemon.xaml
    /// </summary>
    public partial class Wdemon : Window
    {
        Administration donnee;
        public Wdemon(object e)
        {
            donnee = (Administration)e;
            InitializeComponent();
        }
        private void ValidClick(object sender, RoutedEventArgs e)
        {
            donnee.ToutLePersonnel.Add(new Demon(int.Parse(tMatricule.Text), tNom.Text, tPrenom.Text, donnee.CastTypeSexe(tSexe.Text), tFonction.Text, int.Parse(tAffectation.Text), int.Parse(tCagnotte.Text), int.Parse(tForce.Text)));
            MessageBox.Show("ajout fait");
            for (int i = 0; i < donnee.ToutLePersonnel.Count; i++)
            {
                MessageBox.Show(donnee.ToutLePersonnel[donnee.ToutLePersonnel.Count() - 1].Nom);
            }
        }
    }
}
