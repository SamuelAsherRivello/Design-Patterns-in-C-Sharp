//The AbstractFactoryExample works with (is coupled to) the Target interface.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            //Create adapter and place a request
            ITarget target = new Adapter();
            //Request are used to call the specific method
            target.Request();
        }
    }
}