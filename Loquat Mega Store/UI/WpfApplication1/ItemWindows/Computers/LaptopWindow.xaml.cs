
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
        public Laptop laptop = new Laptop("Best", "MegaLap", 1.12m, 890.21m, 120, 2, new Dimensions(50, 10, 60),
                new Processor(4, 3.2, 6), new Display(13.2, DisplayType.TFT, DisplayResolution.p1024),
                new Speaker(6.45, 1.8), 1024, 1000, LoquatMegaStore.Enumerators.Color.Gray);
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
