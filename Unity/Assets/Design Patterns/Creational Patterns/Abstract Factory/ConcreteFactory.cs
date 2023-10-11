//The Concrete Factory class is responsible for creating the concrete products
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{

    public class ConcreteFactory : MonoBehaviour, IAbstractFactory
    {
        [SerializeField] private GameObject productA;
        [SerializeField] private MonoBehaviour[] productAComponents;
        [SerializeField] private GameObject productB;
        [SerializeField] private MonoBehaviour[] productBComponents;

        public IAbstractProduct CreateProductA()
        {
            return CreateProductA();
        }

        public IAbstractProduct CreateProductB()
        {
            return CreateProductB();
        }

        //Create ConcreteProduct A and Add the components
        private IAbstractProduct CreateProductA()
        {
            GameObject product = Instantiate(productA);
            foreach (MonoBehaviour component in productAComponents)
            {
                product.AddComponent(component.GetType());
            }

            return product.GetComponent<IAbstractProduct>();
        }

        //Create ConcreteProduct B and Add the components
        private IAbstractProduct CreateProductB()
        {
            GameObject product = Instantiate(productB);
            foreach (MonoBehaviour component in productBComponents)
            {
                product.AddComponent(component.GetType());
            }

            return product.GetComponent<IAbstractProduct>();
        }
    }
}
    