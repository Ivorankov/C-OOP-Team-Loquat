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
using LoquatMegaStore.Items;
using LoquatMegaStore.Structures;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Desktop.xaml
    /// </summary>
    public partial class DesktopWindow : Window
    {
        public Desktop desktop = new Desktop("Best", "MegaDesk", 3.12m, 1200m, 250, 5, new Dimensions(30, 80, 60),
                new Processor(8, 4.8, 6),16, 2256, LoquatMegaStore.Enumerators.Color.Black);
        public DesktopWindow()
        {
            InitializeComponent();

            TextBlock.Text = desktop.ToString();
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
                MainWindow.customer.UserCart.Items.Add(desktop);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
