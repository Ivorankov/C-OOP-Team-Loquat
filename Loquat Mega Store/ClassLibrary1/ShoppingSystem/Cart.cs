namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Collections;
    ﻿using LoquatMegaStore.Items;
    using System.Collections.Generic;
    using System.Linq;

    public class Cart
    {
        private decimal cartPrice;

        public Cart()
        {
            this.Items = new List<Item>();
        }

        public decimal CartPrice
        {
            get { return this.cartPrice; }
            private set
            {
                foreach (Item item in Items)
                {
                    this.cartPrice += item.Price;
                }
            }
        }

        public IList Items { get; set; }

        public void ViewCartDetails()
        {
            if (this.Items.Count == 0)
            {
                Console.WriteLine("The cart is empty");
            }
            else
            {
                Console.WriteLine("The cart has {0} items in it:\n{1}", this.Items.Count, this.Items.ToString()); // done? TODO show the items or make a method for this. Трябва да се помисли
            }
        }

        public void CheckOut()
        {

            Items.Clear();
        }

        public override string ToString()
        {
            var list = this.Items as List<Item>;

            var str = string.Join(Environment.NewLine, list);

            return str;
        }
    }
}
