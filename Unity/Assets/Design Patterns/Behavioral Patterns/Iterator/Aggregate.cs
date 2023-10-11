//The Aggregate is the one that will be used to create the iterator.
namespace DesignPatterns.BehavioralPatterns.IteratorPattern
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}