//The Concrete Iterator is the one that will be used to iterate through the collection.

namespace DesignPatterns.BehavioralPatterns.IteratorPattern
{
    public class ConcreteIterator : IIterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
                _current++;
            }

            return ret;
        }

        public bool HasNext()
        {
            return _current < _aggregate.Count;
        }
    }
}