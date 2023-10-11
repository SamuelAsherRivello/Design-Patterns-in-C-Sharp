//The Adapter pattern is used to convert the interface of a class into another interface the clients expect.
//Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
//The Adapter pattern is also known as the Wrapper pattern.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class Adapter : MonoBehaviour, ITarget
    {
        private readonly Adaptee _adaptee = new();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}