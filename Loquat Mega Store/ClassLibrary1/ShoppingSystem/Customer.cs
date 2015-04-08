namespace LoquatMegaStore.ShoppingSystem
{
    using System.Collections.Generic;

    public class Customer : User
    {
         public Customer(string userId, string password, string email)
            : base(userId, password, email)
        {
            this.UserCart = new Cart();
            this.OrderList = new List<Order>();
        }

         public Cart UserCart { get; private set; }

         public IList<Order> OrderList { get; set; }
    }
}
