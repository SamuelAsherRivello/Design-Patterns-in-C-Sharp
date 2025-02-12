//The AbstractFactoryExample in a Decorator Pattern is the client code that works with the component interface. It can be a simple or complex component. The client code is coupled to the Component interface. The client code can work with both simple and complex components via the Component interface.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.DecoratorPattern
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            //Create a simple component
            IComponent component = new ConcreteComponent();
            //Create a decorator
            IDecorator decorator = new ConcreteDecoratorA(component);
            //Call the primary method
            decorator.Operation();
            //Call the secondary method
            decorator.SecondaryOperation();
        }
    }
}