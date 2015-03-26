using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoquatMegaStore.ShoppingSystem
{
    public class Customer : User
    {
        public Cart UserCart { get; set; }//TODO: Validation
        public Customer(string userId, string password, string email)
            : base(userId, password, email)
        {
            this.UserCart = new Cart();
            
        }

        
    }
}
