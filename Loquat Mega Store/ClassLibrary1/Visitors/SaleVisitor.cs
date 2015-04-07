namespace LoquatMegaStore.Visitors
{
    using System;

    using LoquatMegaStore.Items;

    public class SaleVisitor : IVisitor
    {
        public void Visit(Item product)
        {
            if (product != null)
            {
                // Sale: 30% off the price on all items
                product.Price *= 0.7M;
                Console.WriteLine(
                "This {0} is now on sale for just {1:C}!", product.GetType().Name, product.Price);
            }
        }
    }
}
