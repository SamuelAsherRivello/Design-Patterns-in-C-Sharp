//The Concrete Aggregate is the one that will be used to create the iterator.

using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.IteratorPattern
{
    public class ConcreteAggregate : IAggregate
    {
        private readonly List<object> _items = new();

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}