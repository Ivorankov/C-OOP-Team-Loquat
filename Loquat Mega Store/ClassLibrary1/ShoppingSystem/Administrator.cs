namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public class Administrator : User
    {
        public Administrator(string userId, string password)
            : base(userId, password, null)
        {

        }
    }
}
