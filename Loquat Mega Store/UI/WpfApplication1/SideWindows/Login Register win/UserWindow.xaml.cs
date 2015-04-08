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
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public string Password
        {
            get { return TextBox1.Password; }
            set { TextBox1.Password = value; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = GetUserEmail();
            Customer customer = new Customer(UserName, Password, email);
            bool isValid = Authentication.LoginUser(customer);
            if (isValid)
            {
                MainWindow.customer = customer;
                MessageBox.Show("You sucsessfully loged it :)");
            }
            else
            {
                MessageBox.Show("Loging failed :(");
            }

        }

        private string GetUserEmail()
        {
            string email = string.Empty;
            using (StreamReader reader = new StreamReader("../../DB/UsersDB.txt"))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] arr = line.Split(' ');
                    if (arr[0] == UserName)
                    {
                        email = arr[2];
                        break;
                    }
                    line = reader.ReadLine();
                } while (line != null);
            }
            return email;
        }
    }
}
