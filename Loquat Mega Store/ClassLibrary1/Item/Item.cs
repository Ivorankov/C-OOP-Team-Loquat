using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoquatMegaStore
{
    public abstract class Item: ICartAddable
    {
        private string manufacturer;
        private string model;
        private decimal price;
        private int ammountInStock;

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (value.Length == null || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer name must contain at least 2 symbols");
                }
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == null || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Model name must contain at least 2 symbols");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must have a non negative value");
                }
                this.price = value;
            }
        }
        public int AmountInStock
        {
            get { return this.ammountInStock; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount of items cannot be less then 0");
                }
                this.ammountInStock = value;
            }
        }
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
