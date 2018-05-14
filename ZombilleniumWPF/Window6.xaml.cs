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
using System.IO;


namespace ZombilleniumWPF
{
    /// <summary>
    /// Logique d'interaction pour Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        delegate void MesMethodes(int id);
        event MesMethodes Evenement;
        
        public Window6()
        {
            
            InitializeComponent();
            Monstre donnee = new Monstre(55, "Ben", "beno", 0, "fonction", 45, 500);
            this.DataContext = donnee;
            // += (id) => { ID.Content = id; };
        }
    }
}
