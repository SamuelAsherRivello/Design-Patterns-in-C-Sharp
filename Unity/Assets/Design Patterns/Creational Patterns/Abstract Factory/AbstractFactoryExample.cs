//The AbstractFactoryExample class is responsible for interacting with the factory and the products through the abstract interfaces

using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryExample : MonoBehaviour
    {
        private IAbstractFactory _abstractFactory;
        private IAbstractProductA _abstractProductA;
        private IAbstractProductB _abstractProductB;

        private void Start()
        {
            _abstractFactory = new ConcreteFactory();
            _abstractProductA = _abstractFactory.CreateProductA();
            _abstractProductB = _abstractFactory.CreateProductB();
            _abstractProductA.UsefulMethodA();
            _abstractProductB.UsefulMethodB();
        }
    }
}