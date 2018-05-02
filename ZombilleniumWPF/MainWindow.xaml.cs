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
    }
}
