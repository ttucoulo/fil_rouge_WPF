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
    /// Logique d'interaction pour WSortie.xaml
    /// </summary>
    public partial class WSortie : Window
    {
        Administration donnee;
        public WSortie(object e)
        {
            donnee = (Administration)e;
            InitializeComponent();
        }
        private void b1_click(object sender, RoutedEventArgs e)
        {
            WAfficheM mw2 = new WAfficheM(donnee);
            this.Close();
            mw2.Show();
        }
        private void b2_click(object sender, RoutedEventArgs e)
        {
            Window3 mw2 = new Window3(donnee);
            this.Close();
            mw2.Show();
        }
        private void b3_click(object sender, RoutedEventArgs e)
        {
            WAfficheD mw2 = new WAfficheD(donnee);
            this.Close();
            mw2.Show();
        }
    }
}
