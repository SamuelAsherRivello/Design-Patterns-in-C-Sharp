//The Object Structure can enumerate its elements.

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public interface IComponent
    {
        void Add(IElement element);
        void Remove(IElement element);
        void Accept(IVisitor visitor);
    }
}