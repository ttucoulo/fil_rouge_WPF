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
    /// Logique d'interaction pour Window22.xaml
    /// </summary>
    
    public partial class Window22 : Window
    {
        Administration donnee;
        public Window22(object e)
        {
            donnee = (Administration)e;
            InitializeComponent();
        }
        private void b1_click(object sender, RoutedEventArgs e)
        {
            Window2222 mw2 = new Window2222(donnee);
            this.Close();
            mw2.Show();

        }
        private void b2_click(object sender, RoutedEventArgs e)
        {
            Wsorcier mw2 = new Wsorcier(donnee);
            this.Close();
            mw2.Show();
        }
        private void b3_click(object sender, RoutedEventArgs e)
        {
            Wvampire mw2 = new Wvampire(donnee);
            this.Close();
            mw2.Show();
        }
        private void b4_click(object sender, RoutedEventArgs e)
        {
            Wloupgarou mw2 = new Wloupgarou(donnee);
            this.Close();
            mw2.Show();

        }
        private void b5_click(object sender, RoutedEventArgs e)
        {
            Wdemon mw2 = new Wdemon(donnee);
            this.Close();
            mw2.Show();
        }
        private void b6_click(object sender, RoutedEventArgs e)
        {
            Wfantome mw2 = new Wfantome(donnee);
            this.Close();
            mw2.Show();
        }
    }
}
