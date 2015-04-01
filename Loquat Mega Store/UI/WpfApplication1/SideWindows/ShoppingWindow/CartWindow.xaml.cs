﻿using LoquatMegaStore.ShoppingSystem;
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
using WpfApplication1.SideWindows.ShoppingWindow;

namespace WpfApplication1.SideWindows
{
    /// <summary>
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public static OrderWindow order = new OrderWindow();
        public CartWindow()
        {
            InitializeComponent();
            //TextBox.Text = MainWindow.customer.UserCart.ToString();
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            if (order.IsActive == false)
            {
                order = new OrderWindow();
                order.Show();
            }
            else
            {
                order.Show(); 
            }     
        }
    }
}