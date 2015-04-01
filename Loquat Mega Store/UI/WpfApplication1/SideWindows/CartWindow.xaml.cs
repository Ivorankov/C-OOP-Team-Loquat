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

namespace WpfApplication1.SideWindows
{
    /// <summary>
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            TextBox.Text = MainWindow.customer.UserCart.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Order order = new Order();
            //MainWindow.customer.OrderList.Add();
            //MainWindow.customer.UserCart.CheckOut();
            
        }
    }
}