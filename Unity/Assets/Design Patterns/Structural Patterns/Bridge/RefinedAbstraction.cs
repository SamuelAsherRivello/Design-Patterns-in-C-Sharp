//The RefinedAbstraction extends the interface defined by Abstraction.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.BridgePattern
{
    public class RefinedAbstraction : Abstraction
    {
        //The RefinedAbstraction extends the interface defined by Abstraction.
        public override void Operation()
        {
            implementor.Operation();
            Debug.Log("Called RefinedAbstraction.Operation()");
        }
    }
}