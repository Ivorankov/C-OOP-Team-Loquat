namespace LoquatMegaStore.Visitors
{
    using System;

    using LoquatMegaStore.ShoppingSystem;

    public class GiftVisitor : IVisitor
    {
        public void Visit(Cart cart)
        {
            if (cart != null)
            {
                Console.WriteLine("We are sending you an Easter basket with your order!");
                // to implement: cart.Items.Add(gift);                
            }
        }
    }
}
