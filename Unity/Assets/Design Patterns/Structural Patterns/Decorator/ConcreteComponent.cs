//The ConcreteComponent class defines an object to which additional responsibilities can be attached.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.DecoratorPattern
{
    public class ConcreteComponent : MonoBehaviour, IComponent
    {
        public void Operation()
        {
            Debug.Log("ConcreteComponent.Operation()");
        }

        public void SecondaryOperation()
        {
            Debug.Log("ConcreteComponent.SecondaryOperation()");
        }
    }
}