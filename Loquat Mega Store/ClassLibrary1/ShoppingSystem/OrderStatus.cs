namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;

    public enum OrderStatus     //Shouldn't this be in enums?Alex
    {
        New,
        OnHold,
        Shipped,
        Delivered,
        Closed
    }
}
