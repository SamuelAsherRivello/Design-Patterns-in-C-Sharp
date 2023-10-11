//The concrete products are the products that will be created by the factory

using UnityEngine;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class ConcreteProduct : MonoBehaviour
    {
        public void Activate()
        {
            Debug.Log("ConcreteProduct Activated");
        }
    }
}