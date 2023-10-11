//The RealSubject contains some core business logic. Usually, RealSubjects are capable of doing some useful work which may also be very slow or sensitive - e.g. correcting input data. A Proxy can solve these issues without any changes to the RealSubject's code.

using UnityEngine;

namespace DesignPatterns.StructuralPatterns.ProxyPattern
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Debug.Log("RealSubject: Handling Request.");
        }
    }
}