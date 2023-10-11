//The VisitorExample

using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public static class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
    
    public class VisitorExample : MonoBehaviour
    {
        private void Start()
        {
            ConcreteComponent concreteComponentA = new ConcreteComponent();
            ConcreteComponent concreteComponentB = new ConcreteComponent();
            
            List<IComponent> components = new List<IComponent>
            {
                concreteComponentA,
                concreteComponentB
            };

            var visitor1 = new ConcreteVisitor();
            Client.ClientCode(components,visitor1);

            var visitor2 = new ConcreteVisitor();
            Client.ClientCode(components,visitor2);
            
        }
    }
}