namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public class Administrator : User
    {
        public Administrator(string userId, string password, string email)
            : base(userId, password, email)
        {

        }
    }
}
