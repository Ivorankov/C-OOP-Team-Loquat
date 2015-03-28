namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

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
