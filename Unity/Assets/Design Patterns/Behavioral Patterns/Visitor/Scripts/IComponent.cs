//The Object Structure can enumerate its elements.

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}