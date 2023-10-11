//The Concrete Factory class is responsible for creating the concrete products
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class ConcreteFactory : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }

    }
}