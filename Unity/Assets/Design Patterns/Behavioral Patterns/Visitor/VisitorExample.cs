//The AbstractFactoryExample
//The AbstractFactoryExample is only responsible for executing the state transition methods.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public class VisitorExample : MonoBehaviour
    {
        private IComponent _component;

        private void Start()
        {
            // Create new object structure
            _component = new ConcreteComponent();

            // Add new elements
            _component.Add(new ConcreteElementA());
            _component.Add(new ConcreteElementB());

            // Execute visitor
            _component.Accept(new ConcreteVisitorA());

            // Execute visitor
            _component.Accept(new ConcreteVisitorB());
        }
    }
}