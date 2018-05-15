﻿using System;
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
        
        Administration donnee;
        public Window6(object a)
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
                Window6b mw2 = new Window6b(donnee,matricule);
                this.Close();
                mw2.Show();
            }
        }
    }
}
