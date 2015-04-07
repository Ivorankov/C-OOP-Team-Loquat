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
    /// Interaction logic for LoudSpeaker.xaml
    /// </summary>
    public partial class LoudSpeakerWindow : Window
    {
        public SoundPlayer soundPlayer = new SoundPlayer("Best", "MegaPlayer", 1.12m, 890.21m, 120, 2, new Dimensions(50, 10, 60),
        new Speaker(6.45, 1.8), new Display(13.2, DisplayType.TFT, DisplayResolution.p1024), 600, LoquatMegaStore.Enumerators.Color.Gray,
        12, AudioFormat.МP3);
        public LoudSpeakerWindow()
        {
            InitializeComponent();
            TextBlock.Text = soundPlayer.ToString();
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
                MainWindow.customer.UserCart.Items.Add(soundPlayer);
                MessageBox.Show("Item added to shopping cart!");
            }
        }
    }
}
