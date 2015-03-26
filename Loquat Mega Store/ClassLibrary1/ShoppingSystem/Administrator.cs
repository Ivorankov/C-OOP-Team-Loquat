using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoquatMegaStore.ShoppingSystem
{
    public class Administrator : User
    {
        public Administrator(string userId, string password)
            : base(userId, password, null)
        {

        }
    }
}
