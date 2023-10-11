//The AbstractFactoryExample is the one that will be calling the command.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.CommandPattern
{
    public class Client : MonoBehaviour
    {
        //Similar to the invoker, the client will be expecting a command.
        private readonly ICommand _command;

        //The client will be expecting a reciever to be passed in.
        public Client(Reciever reciever)
        {
            //The client will be expecting a command to be passed in.
            _command = new ConcreteCommand(reciever);
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) ExecuteCommand(Vector3.forward);
            if (Input.GetKeyDown(KeyCode.S)) ExecuteCommand(Vector3.back);
            if (Input.GetKeyDown(KeyCode.A)) ExecuteCommand(Vector3.left);
            if (Input.GetKeyDown(KeyCode.D)) ExecuteCommand(Vector3.right);
        }

        //The client will be expecting a direction to be passed in.
        public void ExecuteCommand(Vector3 direction)
        {
            _command.Execute(direction);
        }
    }
}