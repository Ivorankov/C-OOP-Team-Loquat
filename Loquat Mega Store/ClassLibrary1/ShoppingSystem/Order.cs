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
            this.OrderDate = DateTime.Now;
        }

        public PaymentType PaymentMethod { get; set; }
        public int OrderID { get; set; }
        public OrderStatus Status { get; private set; }
        public double ShippingFee { get; private set; }
        public int Items { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime OrderDate { get; private set; }

        public void PlaceOrder()
        {
            this.Status = OrderStatus.New;
        }
        
        public void Cancel()
        {
            this.Status = OrderStatus.Cancelled;
        }
    }
}
