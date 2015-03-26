using System;
using System.Collections;
﻿using LoquatMegaStore.Items;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoquatMegaStore.ShoppingSystem
{
    public class Cart
    {
        public IList Items { get; set; }

        public Cart()
        {
            this.Items = new List<Item>();
        }

        public void ViewCartDetails()
        {
            if (this.Items.Count==0)
            {
                Console.WriteLine("The cart is empty");
            }
            else
            {
                Console.WriteLine("The cart has {0} items in it",this.Items.Count); //TODO show the items or make a method for this. Трябва да се помисли
            }
        }



        public void CheckOut()
        {

        }
    }
}
