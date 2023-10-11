//The Object Structure can enumerate its elements.

using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public class ConcreteComponent : IComponent
    {
        private readonly List<IElement> elements = new();

        public void Add(IElement element)
        {
            elements.Add(element);
        }

        public void Remove(IElement element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in elements) element.Accept(visitor);
        }
    }
}