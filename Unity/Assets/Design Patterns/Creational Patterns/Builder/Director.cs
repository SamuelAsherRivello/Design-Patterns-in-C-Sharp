//The Builder is an interface for creating a complex object. It allows you to separate the construction of a complex object from its representation so that the same construction process can create different representations.

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }
        
        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}