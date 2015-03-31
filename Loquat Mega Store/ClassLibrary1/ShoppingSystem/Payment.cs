namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    class Payment
    {
        public DateTime PaymentDate { get; set; }
        //public Address billingAddress { get; set; } -> class needed?, can be same as shipping address
        //others: payment type [enum], cardinfo? --> to be discussed
    }
}
