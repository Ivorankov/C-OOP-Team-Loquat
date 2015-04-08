namespace LoquatMegaStore.Visitors
{
    using LoquatMegaStore.Items;
    using LoquatMegaStore.ShoppingSystem;

    public interface IVisitor
    {
        void Visit(Item product);
    }
}
