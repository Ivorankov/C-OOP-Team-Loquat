
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
using LoquatMegaStore.ShoppingSystem;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Laptop.xaml
    /// </summary>
    public partial class LaptopWindow : Window
    {
        public Laptop laptop = new Laptop("Testt", "Mod", 1.12m, 23.21m, 120, 2, new Dimensions(2, 2, 2),
                new Processor(4, 25.2, 6), new Display(12.2, DisplayType.TFT, DisplayResolution.p1024),
                new Speaker(50.5, 4.5), 256, 1000, LoquatMegaStore.Enumerators.Color.White);
        public LaptopWindow()
        {
            InitializeComponent();

            LaptopInformation.Text = laptop.ToString();
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
                MainWindow.customer.UserCart.Items.Add(laptop);
                MessageBox.Show("Item added to shopping cart!");
            }
        }

    }
}
