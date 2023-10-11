//The Subject interface declares a set of methods for managing subscribers.

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}