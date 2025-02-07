//The Concrete Handler classes contain the actual handling code.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPattern
{
    public class ConcreteHandler1 : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public Response Handle(Request request)
        {
            if (request.Priority == 1)
            {
                Debug.Log("Request " + request.Name + " was handled by ConcreteHandler1");
                return new Response(true);
            }

            if (nextHandler != null)
                return nextHandler.Handle(request);
            return new Response(false);
        }
    }

    public class ConcreteHandler2 : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public Response Handle(Request request)
        {
            if (request.Priority == 2)
            {
                Debug.Log("Request " + request.Name + " was handled by ConcreteHandler2");
                return new Response(true);
            }

            if (nextHandler != null)
                return nextHandler.Handle(request);
            return new Response(false);
        }
    }
}