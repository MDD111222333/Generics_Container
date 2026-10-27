namespace Generics_Container
{
    public class CountingContainer<T> : Container<T>
    {
        public int TotalAdded { get; private set; }

        public override void Add(T item)
        {
            base.Add(item);
            TotalAdded++;
        }
    }
}