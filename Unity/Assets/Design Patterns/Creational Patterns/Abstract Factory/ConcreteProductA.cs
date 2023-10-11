//The concrete products are the products that will be created by the factory
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class ConcreteProductA : IAbstractProductA
    {
        public void UsefulMethodA()
        {
            Debug.Log("ConcreteProductA.UsefulMethodA()");
        }
    }
}