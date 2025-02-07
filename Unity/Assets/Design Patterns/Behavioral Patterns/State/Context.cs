//The Context defines the interface of interest to clients. It also maintains a reference to an instance of a State subclass, which represents the current state of the Context.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            State = null;
        }

        public IState State
        {
            get => _state;
            set
            {
                _state = value;
                Debug.Log("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}