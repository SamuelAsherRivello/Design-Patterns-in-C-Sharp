//The ConcreteFlyweight class implements the Flyweight interface and adds storage for intrinsic state, if any. A ConcreteFlyweight object must be sharable. Any state it stores must be intrinsic; that is, it must be independent of the ConcreteFlyweight object's context.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.FlyweightPattern
{
    public class ConcreteFlyweight : MonoBehaviour, IFlyweight
    {
        private string _intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        private void OnEnable()
        {
            //Add the flyweight to the flyweight pool
            //GameManager.Instance.GetFlyweeightFactory().AddFlyweight(name, this);
        }

        public void Operation()
        {
            Debug.Log("ConcreteFlyweight.Operation()");
        }

        public void SecondaryOperation()
        {
            Debug.Log("ConcreteFlyweight.SecondaryOperation()");
        }
    }
}