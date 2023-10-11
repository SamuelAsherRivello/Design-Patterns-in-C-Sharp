//The Concrete Builder class is responsible for creating the concrete products

using UnityEngine;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class BuilderExample : MonoBehaviour
    {
        protected void Start()
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var builder = new ConcreteBuilder();
            
            // Example 01
            // The Director can construct several product variations using the Builder
            var director = new Director();
            director.Builder = builder;
            director.BuildMinimalViableProduct();
            director.BuildFullFeaturedProduct();
            
            // Example 02
            // Remember, the Builder pattern can be used without a Director
            builder.BuildPartA();
            builder.BuildPartC();

            
        }
    }
}