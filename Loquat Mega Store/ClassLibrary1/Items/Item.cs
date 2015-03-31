﻿using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LoquatMegaStore.Items
{
    using System;
    using System.Linq;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

	public enum Color
		{
		White, Black, Blue, Yellow, Green, Red, Cyan, Magenta, Orange, Gray
		}

    public abstract class Item : ICartAddable
    {
        private string manufacturer;
        private string model;
        private decimal price;
        private decimal weight;
        private int powerConsumption;
        private int ammountInStock;
        private Dimensions dimensions;
        private Color color;
        private PropertyInfo[] properties = null;

        public Item() //MAKES THE PROGRAM BUILD ( TO BE DELETED )
        {
        }
        public Item(string manufacturer, string model, decimal price, int amountInStock)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.AmountInStock = amountInStock;
        }
        public Item(string manufacturer, string model, decimal price, decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions, Color color)
            : this(manufacturer, model, price, amountInStock)
        {
            this.Weight = weight;
            this.PowerConsumption = powerConsumption;
            this.dimensions = dimensions;
            this.Color = color;
        }
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
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            if (properties == null)
            {
                properties = this.GetType().GetProperties();
            }

            var result = new StringBuilder();


            foreach (var info in properties)
            {
                var value = info.GetValue(this, null) ?? "";
                var valueAsString = String.Empty;

                if (value is IEnumerable && !(value is String))
                {
                    var items = new List<string>();
                    foreach (var item in (value as IEnumerable))
                    {
                        items.Add(item.ToString());
                    }
                    valueAsString = String.Join(", ", items);
                }
                else
                {
                    valueAsString = value.ToString();
                }

                result.AppendLine(String.Format("{0, -20} : {1, 20}", info.Name, valueAsString));

            }

            return result.ToString().Trim();
        }
    }
}
