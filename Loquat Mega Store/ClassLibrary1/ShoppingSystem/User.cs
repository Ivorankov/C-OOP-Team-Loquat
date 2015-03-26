using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using LoquatMegaStore.Interfaces;

namespace LoquatMegaStore.ShoppingSystem
{
    public abstract class User: IPayable, IOrderable
    {
        private string userId;
        private string password;
        private string email;

        protected User(string userId, string password, string email)
        {
            this.UserId = userId;
            this.Password = password;
            this.Email = email;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Password
        {
            internal get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
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
