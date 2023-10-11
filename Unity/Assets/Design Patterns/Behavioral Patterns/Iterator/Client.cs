//The AbstractFactoryExample is the one that will be used to create the iterator and iterate through the collection.
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.IteratorPattern
{
    public class Client
    {
        public void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
            IIterator i = a.CreateIterator();
            object item = i.Next();
            while (item != null)
            {
                Debug.Log(item);
                item = i.Next();
            }
        }
    }
}
