//The Composite class represents the complex components that may have children.
//It stores child components and implements child-related operations in the Component interface.

using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new();

        public void Operation()
        {
            foreach (var component in _children) component.Operation();
        }

        public void SecondaryOperation()
        {
            foreach (var component in _children) component.SecondaryOperation();
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }
    }
}