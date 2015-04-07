using LoquatMegaStore.Enumerators;
using LoquatMegaStore.Items;
using LoquatMegaStore.Structures;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TVWindow.xaml
    /// </summary>
    public partial class TVWindow : Window
    {
        public TV TV = new TV("Best", "MegaLap", 1.12m, 890.21m, 120, 2, new Dimensions(50, 10, 60), LoquatMegaStore.Enumerators.Color.Gray,
        new Speaker(60, 4.5), new Display(13.2, DisplayType.SUHD, DisplayResolution.UHD));
        public TVWindow()
        {
            InitializeComponent();
            TextBlock.Text = TV.ToString();
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
                MainWindow.customer.UserCart.Items.Add(TV);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
