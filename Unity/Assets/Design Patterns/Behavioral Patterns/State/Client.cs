//The AbstractFactoryExample is only responsible for executing the state transition methods.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            // Create new context
            var context = new Context();
            // Initialize with ConcreteStateA
            context.State = new ConcreteStateA();
            // Execute state transition
            context.Request();
            // Execute state transition
            context.Request();
            // Execute state transition
            context.Request();
        }
    }
}