//The Component interface declares common operations for both simple and complex objects of a composition.

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public interface IComponent
    {
        void Operation();
        void SecondaryOperation();
    }
}