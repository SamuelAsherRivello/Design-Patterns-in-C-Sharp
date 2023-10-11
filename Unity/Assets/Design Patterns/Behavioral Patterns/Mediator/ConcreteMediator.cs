//The Concrete Mediator is the one that will be used to communicate between the Colleagues.

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { set; get; }

        public ConcreteColleague2 Colleague2 { set; get; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
                Colleague2.Notify(message);
            else
                Colleague1.Notify(message);
        }
    }
}