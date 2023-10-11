//The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

using System;
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    public class Observer : MonoBehaviour
    {
        private void Start()
        {
            // Create IBM stock and attach investors
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }

    public class IBM : ISubject
    {
        public IBM(string ibm, double d)
        {
            throw new NotImplementedException();
        }

        public double Price { get; set; }

        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Detach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class Investor : IObserver
    {
        public Investor(string name)
        {
        }

        public void Update(ISubject subject)
        {
        }
    }
}