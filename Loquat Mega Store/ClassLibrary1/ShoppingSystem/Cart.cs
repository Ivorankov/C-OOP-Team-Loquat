namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using LoquatMegaStore.Items;
    using LoquatMegaStore.Visitors;

    public class Cart
    {
        private decimal cartPrice;
        private IList items;

        public Cart()
        {
            this.Items = new List<Item>();
            this.OnSale = false;
        }
               
        public decimal CartPrice
        {
            get { return this.cartPrice; }
            private set
            {
                // Apply visitors if the sale is active [logic needs improvement]
                foreach (Item item in Items)
                {
                    if (this.OnSale)
                    {
                        item.Accept(new SaleVisitor());
                    }                     
                    this.cartPrice += item.Price;
                }
            }
        }
        
        public IList Items
        {
            get { return items; }
            set { items = value; }
        }
       
        public bool OnSale { get; set; }

        public void ViewCartDetails()
        {
            if (this.Items.Count == 0)
            {
                Console.WriteLine("The cart is empty");
            }
            else
            {
                Console.WriteLine("The cart has {0} items in it:\n{1}", this.Items.Count, this.Items.ToString()); 
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
