using System.Collections.Generic;

namespace Generics_Container
{
    public class Container<T>
    {
        protected List<T> items = new List<T>();

        public virtual void Add(T item)
        {
            items.Add(item);
        }

        public int Count => items.Count;
    }
}