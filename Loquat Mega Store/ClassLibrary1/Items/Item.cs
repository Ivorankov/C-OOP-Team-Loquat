namespace LoquatMegaStore.Items
{
    using System;
    using System.Linq;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;

    public abstract class Item : ICartAddable
    {
        private string manufacturer;
        private string model;
        private decimal price;
        private decimal weight;
        private int powerConsumption;
        private int ammountInStock;
        private Dimensions dimensions;

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length == 0 || value.Length < 2)
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
                if (value.Length == 0 || value.Length < 2)
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
        public int PowerConsumption
        {
            get { return this.powerConsumption; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Apliances cannot consume negative or 0 amount of energy");
                }
                this.powerConsumption = value;
            }
        }
        public Item() //MAKES THE PROGRAM BUILD ( TO BE DELETED )
        {

        }
        public Item(string manufacturer, string model, decimal price, decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Weight = weight;
            this.PowerConsumption = powerConsumption;
            this.AmountInStock = amountInStock;
            this.dimensions = dimensions;
        }

        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
