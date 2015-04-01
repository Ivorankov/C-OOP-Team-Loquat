using LoquatMegaStore.ShoppingSystem;
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
using LoquatMegaStore.Enumerators;
using LoquatMegaStore.ShoppingSystem.Enumerators;

namespace WpfApplication1.SideWindows.ShoppingWindow
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }
        public string Address
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public string ContactName
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.customer.MakeOrder(this.ContactName, this.Address);
                MessageBox.Show("Order successfull!\nThank you for shopping in Loquat :) ");
                CartWindow.order.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must be logged in to make orders!");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CartWindow.order.Close();
        }
    }
}
