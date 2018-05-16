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
    /// Logique d'interaction pour WfaireEvoluer.xaml
    /// </summary>
    public partial class WfaireEvoluer : Window
    {
        Administration donnee;
        int matricule;
        public WfaireEvoluer(object e,int mat)
        {
            donnee = (Administration)e;
            matricule = mat;
            InitializeComponent();
        }
        private void chf_click(object sender, RoutedEventArgs e)
        {
            WchF mw2 = new WchF(donnee,matricule);
            this.Close();
            mw2.Show();
        }
        private void cha_click(object sender, RoutedEventArgs e)
        {
            WchA mw2 = new WchA(donnee,matricule);
            this.Close();
            mw2.Show();
        }
    }
}
