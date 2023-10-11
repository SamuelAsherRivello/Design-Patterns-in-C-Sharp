//The concrete products are the products that will be created by the factory

using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class ConcreteProductB : IAbstractProductB
    {
        public void UsefulMethodB()
        {
            Debug.Log("ConcreteProductB.UsefulMethodB()");
        }
    }
}