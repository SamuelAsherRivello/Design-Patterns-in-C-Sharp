//The Abstraction defines the interface for the "control" part of the two class hierarchies. It maintains a reference to an object of the Implementation hierarchy and delegates all of the real work to this object.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.BridgePattern
{
    public class Abstraction : MonoBehaviour
    {
        //The Abstraction defines the interface for the "control" part of the two class hierarchies. It maintains a reference to an object of the Implementation hierarchy and delegates all of the real work to this object.
        protected IImplementor implementor;

        //The Abstraction defines the interface for the "control" part of the two class hierarchies
        public void SetImplementor(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        //The Abstraction defines the interface for the "control" part of the two class hierarchies
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}