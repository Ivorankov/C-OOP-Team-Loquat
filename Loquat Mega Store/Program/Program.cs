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
            User user = new Customer("pesho2","ivan","az2@abv.bg");

            Authentication.CreateUser(user);

            //Authentication.LoginUser(user);
           
        }
    }
}
