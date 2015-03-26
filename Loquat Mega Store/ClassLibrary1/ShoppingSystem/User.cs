using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoquatMegaStore.ShoppingSystem
{
    public abstract class User: IPayable, IOrderable
    {
        private string userId;
        private string password;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Password
        {
            
            set { password = value; }
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }

        public void MakeOrder()
        {
            throw new NotImplementedException();
        }
    }
}
