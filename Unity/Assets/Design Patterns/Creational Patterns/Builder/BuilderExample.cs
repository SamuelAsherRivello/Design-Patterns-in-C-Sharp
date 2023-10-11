//The Concrete Builder class is responsible for creating the concrete products
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class BuilderExample : MonoBehaviour, IBuilder
    {
        [SerializeField] private GameObject productA;
        [SerializeField] private MonoBehaviour[] productAComponents;
        [SerializeField] private GameObject productB;
        [SerializeField] private MonoBehaviour[] productBComponents;

        public IProduct CreateProductA()
        {
            return CreateProduct();
        }

        public IProduct CreateProductB()
        {
            return CreateProductB();
        }

        //Create ConcreteProduct A and Add the components
        private IProduct CreateProductA()
        {
            GameObject product = Instantiate(productA);
            foreach (MonoBehaviour component in productAComponents)
            {
                product.AddComponent(component.GetType());
            }

            return product.GetComponent<IProduct>();
        }

        //Create ConcreteProduct B and Add the components
        private IProduct CreateProductB()
        {
            GameObject product = Instantiate(productB);
            foreach (MonoBehaviour component in productBComponents)
            {
                product.AddComponent(component.GetType());
            }

            return product.GetComponent<IProduct>();
        }
    }
}