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
    /// Interaction logic for GSMWindow.xaml
    /// </summary>
    public partial class GSMWindow : Window
    {
        public MobilePhone GSM = new MobilePhone("Fruty", "Pineapple", 3.12m, 1200m, 250, 5, new Dimensions(5, 3, 24),
                LoquatMegaStore.Enumerators.Color.Black, new Display(7, DisplayType.LCD, DisplayResolution.p1024),
                new Speaker(1.2,1.8),true,5000,13.6);
        public GSMWindow()
        {
            InitializeComponent();
            TextBlock.Text = GSM.ToString();
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
                MainWindow.customer.UserCart.Items.Add(GSM);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
