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
using LoquatMegaStore.ShoppingSystem;

namespace WpfApplication1.SideWindows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public string Password {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; } 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer user = new Customer(UserName, Password, "testt@mail.bg");
            Authentication.CreateUser(user);
            MessageBox.Show("You successfully registrated :)");
        }
    }
}
