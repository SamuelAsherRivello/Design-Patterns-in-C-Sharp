//The AbstractFactoryExample class is responsible for interacting with the factory and the products through the abstract interfaces
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryExample : MonoBehaviour
    {
        private IAbstractFactory factory;
        private IAbstractProduct productA;
        private IAbstractProduct productB;

        private void Start()
        {
            factory = new ConcreteFactory();
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
            productA.Activate();
            productB.Activate();
        }
    }
}