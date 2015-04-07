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
    /// Interaction logic for ProjectorWindow.xaml
    /// </summary>
    public partial class ProjectorWindow : Window
    {
        public Projector projector = new Projector("Best", "ProLight", 0.600m, 890.21m, 100, 20,
            new Dimensions(50, 10, 60), LoquatMegaStore.Enumerators.Color.Gray, 5000,4000);
        public ProjectorWindow()
        {
            InitializeComponent();
            TextBlock.Text = projector.ToString();
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
                MainWindow.customer.UserCart.Items.Add(projector);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
