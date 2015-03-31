namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;
    using LoquatMegaStore.ShoppingSystem.Enumerators;

    public class Order
    {
        public Order(PaymentType payment, int orderId, OrderStatus orderStatus, double shippingFee,int itemCount,decimal totPrice)
        {
            this.PaymentMethod = payment;
            this.OrderID = orderId;
            this.Status = orderStatus;
            this.ShippingFee = shippingFee;
            this.Items = itemCount;
            this.TotalPrice = itemCount;
        }
        public PaymentType PaymentMethod { get; set; }
        public int OrderID { get; set; }
        public OrderStatus Status { get; set; }
        public double ShippingFee { get; set; }
        public int Items { get; private set; }
        public decimal TotalPrice { get; private set; }
    }
}
