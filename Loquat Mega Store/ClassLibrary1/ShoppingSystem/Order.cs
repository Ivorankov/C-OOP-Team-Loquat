namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.IO;
    using System.Text;

    using LoquatMegaStore.ShoppingSystem.Enumerators;

    public class Order
    {
        public Order(PaymentType payment, int orderId, OrderStatus orderStatus, double shippingFee,
            int itemCount, decimal totPrice, string contactName, string address)
        {
            this.PaymentMethod = payment;
            this.OrderID = orderId;
            this.Status = orderStatus;
            this.ShippingFee = shippingFee;
            this.Items = itemCount;
            this.TotalPrice = totPrice;
            this.OrderDate = DateTime.Now;
            this.ContactName = contactName;
        }

        public PaymentType PaymentMethod { get; set; }
        public int OrderID { get; set; }
        public OrderStatus Status { get; private set; }
        public double ShippingFee { get; private set; }
        public int Items { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string ContactName { get; private set; }
        public string Address { get; private set; }

        public void PlaceOrder()
        {
            this.Status = OrderStatus.New;
        }

        public void SaveOrder()
        {
            if (this.Status == OrderStatus.New)
            {
                using (FileStream orderFileStream = new FileStream("order.txt", FileMode.OpenOrCreate,
                    FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(orderFileStream))
                {

                    writer.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", this.PaymentMethod, this.OrderID,
                        this.Status, this.OrderDate, this.ShippingFee, this.Items, this.TotalPrice, this.ContactName, this.Address));
                        writer.Close();
                }
            }
        }
        public static void StoreOrder(Order order, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, true, Encoding.ASCII);

            using (writer)
            {
                writer.WriteLine(order.ToString());
                writer.Close();
            }
        }
        public void Cancel()
        {
            this.Status = OrderStatus.Cancelled;
        }
    }
}
