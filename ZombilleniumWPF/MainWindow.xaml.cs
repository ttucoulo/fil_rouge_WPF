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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 mw2 = new Window1();
            mw2.Activate();
            MessageBox.Show("saluut");
            
           

        }
        private void  b6_Click(object sender, RoutedEventArgs e)
        {
            //Window w2 = new Window();
            //StackPanel sp2 = new StackPanel();
            //w2.Content = sp2;

        }

    }
}
