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
using LoquatMegaStore.Enumerators;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Laptop.xaml
    /// </summary>
    public partial class LaptopWindow : Window
    {
        public LaptopWindow()
        {
            InitializeComponent();
            Laptop laptop = new Laptop("Testt", "MOdel", 1.12m, 23.21m, 120, 2, new Dimensions(2, 2, 2),
                new Processor(4, 25.2, 6), new Display(12.2, DisplayType.TFT, DisplayResolution.p1024),
                12.5, 14.2, 256, 1000, LoquatMegaStore.Enumerators.Color.Gray);
            Laptop laptop2 = new Laptop("Testt", "MOdel", 1.12m, 23.21m, 120, 2, new Dimensions(2, 2, 2),
                new Processor(4, 25.2, 6), new Display(12.2, DisplayType.TFT, DisplayResolution.p1024),
                12.5, 14.2, 256, 1000, LoquatMegaStore.Enumerators.Color.Gray);
            MessageBox.Show(laptop.ToString());
        }

    }
}
