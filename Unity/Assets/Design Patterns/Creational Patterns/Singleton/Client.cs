//The AbstractFactoryExample in the Singleton pattern is the class that uses the Singleton class.
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public class Client : MonoBehaviour {
        private void Start() {
            //Call the PrintMessage method on the SingletonExample class
            SingletonExample.Instance.PrintMessage();
        }
    }
}