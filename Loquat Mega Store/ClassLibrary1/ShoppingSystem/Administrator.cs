namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public class Administrator : User
    {
        public const bool HasAdminRights = true;

        public Administrator(string userId, string password, string email)
            : base(userId, password, email)
        {

        }
    }
}
