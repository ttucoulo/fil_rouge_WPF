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
    /// Logique d'interaction pour WMatricule.xaml
    /// </summary>
    public partial class WMatricule : Window
    {
        Administration donnee;
        public WMatricule(object a)
        {
            donnee = (Administration)a;
            InitializeComponent();

            this.DataContext = donnee;

        }


        private void ValidClick(object sender, RoutedEventArgs e)
        {

            int matricule = int.Parse(ID.Text);
            int index_monstre = donnee.ReturnIndexList(matricule, true);
            if (index_monstre == 100) MessageBox.Show("Matricule non existant.");
            else
            {
                WfaireEvoluer mw2 = new WfaireEvoluer(donnee, matricule);
                this.Close();
                mw2.Show();
            }
        }
    }
}
