namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    class Order
    {
        public Customer Customer { get; set; }
        public Payment PaymentMethod { get; set; }
        public int OrderID { get; set; }
        public OrderStatus Status { get; set; }
        public double ShippingFee { get; set; } // based on customer address 
        // --> new Address class to store shipping and billing addresses?

    }
}
