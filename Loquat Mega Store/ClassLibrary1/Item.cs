using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoquatMegaStore
{
    public abstract class Item: ICartAddable
    {
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
