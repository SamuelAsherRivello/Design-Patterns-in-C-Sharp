//The Concrete Colleague is the one that will be used to communicate with the Mediator.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.Log("Colleague1 gets message: " + message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.Log("Colleague2 gets message: " + message);
        }
    }
}