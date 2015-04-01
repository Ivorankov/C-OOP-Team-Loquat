namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public enum OrderStatus 
    {
        New,
        OnHold,
        Shipped,
        Delivered,
        Closed
    }
}
