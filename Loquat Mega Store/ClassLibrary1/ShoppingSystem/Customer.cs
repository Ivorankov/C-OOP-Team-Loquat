namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public class Customer : User
    {
         public Customer(string userId, string password, string email)
            : base(userId, password, email)
        {
            this.UserCart = new Cart();

        }
         public Cart UserCart { get; set; }//TODO: Validation

    }
}
