//The prototype Pattern is used to instantiate a new object by copying all of the properties of an existing object, creating an independent clone. This practise is particularly useful when the construction of a new object is inefficient.
using UnityEngine;

namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    public class PrototypeExample : MonoBehaviour {
        //Create a new instance of the class
        private PrototypeExample instance;

        //Create a public method to clone the object
        public PrototypeExample Clone() {
            //Return a copy of the object
            return (PrototypeExample) this.MemberwiseClone();
        }
    }
}
