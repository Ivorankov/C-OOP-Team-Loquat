using LoquatMegaStore.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoquatMegaStore.Interfaces;

namespace LoquatMegaStore
{
    public abstract class Item: ICartAddable
    {
        private string manufacturer;
        private string model;
        private decimal price;
        private decimal weight;
        private int ammountInStock;
        private Dimentions dimentions;

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
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
            set
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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must have a non negative value");
                }
                this.price = value;
            }
        }
        public decimal Weight
        {
            get { return this.weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weight cannot be a negative or 0 value");
                }
                this.weight = value;
            }
        }
        public int AmountInStock
        {
            get { return this.ammountInStock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount of items cannot be less then 0");
                }
                this.ammountInStock = value;
            }
        }
        public Item(string manufacturer, string model, decimal price,decimal weight, int amountInStock,Dimentions dimentions)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Weight = weight;
            this.AmountInStock = ammountInStock;
            this.dimentions = dimentions;
        }
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
