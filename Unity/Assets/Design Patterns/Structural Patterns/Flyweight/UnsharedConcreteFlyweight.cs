//The UnsharedConcreteFlyweight class must be implemented by all concrete flyweights that are not shared. The UnsharedConcreteFlyweight must keep a reference to the FlyweightFactory object, because it needs access to the factory's pool of shared flyweights. The client code must supply the flyweight with its extrinsic state before the client can call the flyweight's methods.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.FlyweightPattern
{
    public class UnsharedConcreteFlyweight : IFlyweight
    {
        private string _extrinsicState;
        private FlyweightFactory _factory;

        public UnsharedConcreteFlyweight(FlyweightFactory factory)
        {
            _factory = factory;
        }

        public void Operation()
        {
            Debug.Log("UnsharedConcreteFlyweight.Operation()");
        }

        public void SecondaryOperation()
        {
            Debug.Log("UnsharedConcreteFlyweight.SecondaryOperation()");
        }

        public void SetExtrinsicState(string state)
        {
            _extrinsicState = state;
        }
    }
}