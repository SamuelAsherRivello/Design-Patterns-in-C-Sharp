//The AbstractFactoryExample is the one that will be used to create the Mediator.
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public class Client : MonoBehaviour 
    {
        private void Start()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks");
        }
    }
}