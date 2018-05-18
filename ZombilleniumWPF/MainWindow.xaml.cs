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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZombilleniumWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 
    enum TypeBoutique { souvenir, barbeAPapa, nourriture };
    enum Grade { novice, mega, giga, strata };
    enum TypeCategorie { assise, inversee, bobsleigh };
    enum TypeSexe { male, femelle, autre };
    enum CouleurZ { bleuatre, grisatre };

    public partial class MainWindow : Window
    {
        Administration donnee = new Administration();
        public MainWindow()
        {
            donnee.AjoutMembresFromCSV("D:/2017-2018/POO/WTF/Listing.csv");
            InitializeComponent();
            Administration a = new Administration();
            a.AjoutMembresFromCSV("D:/2017-2018/POO/WTF/Listing.csv");
            //MessageBox.Show("init fait");
        }
        private void b2_Click(object sender, RoutedEventArgs e)//fait ajouter membre
        {
            Window1 mw2 = new Window1(donnee);
            this.Close();
            mw2.Show();
        }
        private void b3_Click(object sender, RoutedEventArgs e)//fait
        {
            WMatricule mw3 = new WMatricule(donnee);
            this.Close();
            mw3.Show();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            WSortie mw2 = new WSortie(donnee);
            this.Close();
            mw2.Show();
        }
        private void b5_Click(object sender, RoutedEventArgs e)//fait
        {
            WTtis mw2 = new WTtis(donnee);
            this.Close();
            mw2.Show();
        }
        private void  b6_Click(object sender, RoutedEventArgs e)//fait
        {
            Window6 w6 = new Window6(donnee);
            this.Close();
            w6.Show();

        }
        
    }
}
