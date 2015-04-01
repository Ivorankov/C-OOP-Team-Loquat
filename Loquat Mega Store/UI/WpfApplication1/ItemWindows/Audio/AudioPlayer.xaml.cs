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
using LoquatMegaStore.Items;
using LoquatMegaStore.Structures;
using LoquatMegaStore.Enumerators;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for AudioPlayer.xaml 
    /// </summary>
    public partial class AudioPlayerWindow : Window
    {
        public AudioPlayerWindow()
        {
            InitializeComponent();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.customer == null)
            {
                MessageBox.Show("Please login first!");
                var userWindow = new UserWindow();
                userWindow.Show();
            }
            else
            {
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
