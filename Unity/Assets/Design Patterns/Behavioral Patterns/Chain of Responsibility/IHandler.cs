//The Handler interface declares a method for building the chain of handlers.
//It also declares a method for executing a request.

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPattern
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Response Handle(Request request);
    }

    //Sample Request Struct
    public struct Request
    {
        public string Name;
        public string Description;
        public int Priority;

        public Request(string name, string description, int priority)
        {
            Name = name;
            Description = description;
            Priority = priority;
        }
    }

    //Sample Response Struct
    public struct Response
    {
        private bool didPass;

        public Response(bool didPass)
        {
            this.didPass = didPass;
        }
    }
}