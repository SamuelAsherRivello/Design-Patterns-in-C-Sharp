//The ConcreteProduct class is the class that will be created by the Builder

using UnityEngine;

namespace DesignPatterns.CreationalPatterns.BuilderPattern
{
    public class ConcreteProduct : MonoBehaviour, IConcreteProduct
    {
        public delegate void OnActivate();

        private OnActivate onActivate;

        public void Activate()
        {
            onActivate();
        }

        public void AddActivateListener(OnActivate onActivate)
        {
            this.onActivate += onActivate;
        }
    }
}