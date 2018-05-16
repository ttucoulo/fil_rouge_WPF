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
    /// Logique d'interaction pour WTtis.xaml
    /// </summary>
    public partial class WTtis : Window
    {
        Administration donnee;
        
        public WTtis(object e)
        {
            donnee = (Administration)e;
            
            InitializeComponent();
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
           // WtriC mw2 = new WtriC(donnee);
            this.Close();
            //mw2.Show();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            //WtriF mw2 = new WtriF(donnee);
            this.Close();
            //mw2.Show();
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            //WtriCr mw2 = new WtriCr(donnee);
            this.Close();
            //mw2.Show();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            //WtriL mw2 = new WtriL(donnee);
            this.Close();
            //mw2.Show();
        }
    }
}
