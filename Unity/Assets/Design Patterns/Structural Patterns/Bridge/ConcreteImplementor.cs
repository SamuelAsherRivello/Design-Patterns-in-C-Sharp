//The ConcreteImplementor provides the implementation of the Implementor interface and defines its concrete implementation.
using UnityEngine;

namespace DesignPatterns.StructuralPatterns.BridgePattern
{
    public class ConcreteImplementor : MonoBehaviour, IImplementor
    {
        public void Operation()
        {
            Debug.Log("Called ConcreteImplementor.Operation()");
        }
    }
}