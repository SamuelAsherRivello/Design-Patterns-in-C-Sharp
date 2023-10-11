//The Concrete Subject contains some important state and notifies observers when the state changes.
//observer as a MonoBehaviour

using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    public class Subject : MonoBehaviour, ISubject
    {
        private readonly List<IObserver> _observers = new();
        private double _price;

        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers) observer.Update(this);
        }
    }
}