using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoquatMegaStore.ShoppingSystem;
using LoquatMegaStore;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer user = new Customer("pesho5","2a","az5@abv.bg");

            //Authentication.CreateUser(user);
            DateTime date = DateTime.Now;
            //Console.WriteLine(date.Ticks);

            //Authentication.LoginUser(user);

            Administrator admin = new Administrator("pesho5","2");

            //user.UserCart.Items.Add() //Here we add Items to the cart of the user
            Authentication.LoginUser(admin);

           
        }
    }
}
