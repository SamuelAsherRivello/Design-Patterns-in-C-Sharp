//The AbstractFactoryExample in a Decorator Pattern is the client code that works with the component interface. It can be a simple or complex component. The client code is coupled to the Component interface. The client code can work with both simple and complex components via the Component interface.

namespace DesignPatterns.StructuralPatterns.DecoratorPattern
{
    public interface IDecorator
    {
        void Operation();
        void SecondaryOperation();
    }
}