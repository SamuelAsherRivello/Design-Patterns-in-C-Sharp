//IElement interface declares an Accept operation that takes a visitor as an argument.

namespace DesignPatterns.BehavioralPatterns.VisitorPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}