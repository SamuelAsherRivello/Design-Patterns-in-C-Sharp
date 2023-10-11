//The AbstractFactoryExample class is responsible for creating the chain of handlers and passing the request to the first handler.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPattern
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            IHandler handler1 = new ConcreteHandler1();
            IHandler handler2 = new ConcreteHandler2();
            handler1.SetNext(handler2);
            var request = new Request("Request 1", "This is a request", 2);
            handler1.Handle(request);
        }
    }
}