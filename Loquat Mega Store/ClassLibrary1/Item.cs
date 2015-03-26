using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoquatMegaStore
{
    public abstract class Item: ICartAddable
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }
        public int AmountInStock { get; private set; }
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
