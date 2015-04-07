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
    /// Interaction logic for RadioStationWindow.xaml
    /// </summary>
    public partial class RadioStationWindow : Window
    {
        public HomePhone hPhone = new HomePhone("Fruty", "Pineapple", 3.12m, 1200m, 250, 5, new Dimensions(5, 3, 24),
        LoquatMegaStore.Enumerators.Color.Black, new Display(7, DisplayType.LCD, DisplayResolution.p1024),
        new Speaker(1.2, 1.8), 2.30, 5.65);
        public RadioStationWindow()
        {
            InitializeComponent();
            TextBlock.Text = hPhone.ToString();
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
                MainWindow.customer.UserCart.Items.Add(hPhone);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
