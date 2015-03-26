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
            User user = new Customer("pesho4","ivan","az4@abv.bg");

            Authentication.CreateUser(user);
            DateTime date = DateTime.Now;
            //Console.WriteLine(date.Ticks);

            //Authentication.LoginUser(user);
           
        }
    }
}
