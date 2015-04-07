namespace LoquatMegaStore.Visitors
{
    using LoquatMegaStore.Items;

    public interface IVisitor
    {
        void Visit(Item product);
    }
}
