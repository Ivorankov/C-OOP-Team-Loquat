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
using LoquatMegaStore.ShoppingSystem;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public string Password
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer user = new Customer(UserName, Password, "test@mail.bg");
            bool isValid = Authentication.LoginUser(user);
            if (isValid)
            {
                MessageBox.Show("You sucsessfully loged it :)");
            }
            else
            {
                MessageBox.Show("Loging failed :(");
            }
            
        }
    }
}
