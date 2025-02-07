//The AbstractFactoryExample in a Flywheel Pattern is the client code that works with the flyweight interface. It can be a simple or complex flyweight. The client code is coupled to the Flyweight interface. The client code can work with both simple and complex flyweights via the Flyweight interface.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.FlyweightPattern
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            //Create a flyweight factory
            var factory = new FlyweightFactory();
            //Create a flyweight
            var flyweight = factory.GetFlyweight("A");
            //Call the primary method
            flyweight.Operation();
            //Call the secondary method
            flyweight.SecondaryOperation();
        }
    }
}