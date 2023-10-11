//The Iterator is the one that will be used to iterate through the collection.

namespace DesignPatterns.BehavioralPatterns.IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}