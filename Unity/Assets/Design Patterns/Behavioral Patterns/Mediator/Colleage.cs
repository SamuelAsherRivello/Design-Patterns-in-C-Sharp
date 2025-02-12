//The Colleage is the one that will be used to send messages to the Mediator.

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}