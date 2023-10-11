//The Subject interface declares a set of methods for managing subscribers.

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}