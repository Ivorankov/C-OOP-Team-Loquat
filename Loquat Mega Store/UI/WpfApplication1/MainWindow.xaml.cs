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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ivorankov/C-OOP-Team-Loquat");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Aboutwindow aboutWindow = new Aboutwindow();
            aboutWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoudSpeakerWindow loudSpeakr = new LoudSpeakerWindow();
            loudSpeakr.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AudioPlayerWindow audioPlayer = new AudioPlayerWindow();
            audioPlayer.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TVWindow tV = new TVWindow();
            tV.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ProjectorWindow projector = new ProjectorWindow();
            projector.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            DesktopWindow desktop = new DesktopWindow();
            desktop.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            LaptopWindow laptop = new LaptopWindow();
            laptop.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            GSMWindow gSM = new GSMWindow();
            gSM.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            RadioStationWindow radioSt = new RadioStationWindow();
            radioSt.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            UserWindow user = new UserWindow();
            user.Show();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            RegisterWindow regWindow = new RegisterWindow();
            regWindow.Show();
        }
    }
}
