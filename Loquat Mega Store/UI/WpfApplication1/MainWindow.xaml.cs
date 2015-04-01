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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.SideWindows;
using LoquatMegaStore.ShoppingSystem;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Customer customer;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Category_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ivorankov/C-OOP-Team-Loquat");
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Aboutwindow aboutWindow = new Aboutwindow();
            aboutWindow.Show();
        }

        private void LoudSpeaker_Click(object sender, RoutedEventArgs e)
        {
            LoudSpeakerWindow loudSpeakr = new LoudSpeakerWindow();
            loudSpeakr.Show();
        }

        private void AudioPlayer_Click(object sender, RoutedEventArgs e)
        {
            AudioPlayerWindow audioPlayer = new AudioPlayerWindow();
            audioPlayer.Show();
        }

        private void TV_Click(object sender, RoutedEventArgs e)
        {
            TVWindow tV = new TVWindow();
            tV.Show();
        }

        private void Projector_Click(object sender, RoutedEventArgs e)
        {
            ProjectorWindow projector = new ProjectorWindow();
            projector.Show();
        }

        private void Desktop_Click(object sender, RoutedEventArgs e)
        {
            DesktopWindow desktop = new DesktopWindow();
            desktop.Show();
        }

        private void Laptop_Click(object sender, RoutedEventArgs e)
        {
            LaptopWindow laptop = new LaptopWindow();
            laptop.Show();
        }

        private void GSM_Click(object sender, RoutedEventArgs e)
        {
            GSMWindow gSM = new GSMWindow();
            gSM.Show();
        }

        private void RadioSt_Click(object sender, RoutedEventArgs e)
        {
            RadioStationWindow radioSt = new RadioStationWindow();
            radioSt.Show();
        }

        private void LogReg_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            UserWindow user = new UserWindow();
            user.Show();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regWindow = new RegisterWindow();
            regWindow.Show();
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.Show();
        }
    }
}
