//A terminal expression is one that does not contain any other expressions.

using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.InterpreterPattern
{
    public class TerminalExpression : IAbstractExpression
    {
        public void Interpret(Context context)
        {
            Debug.Log("Called Terminal.Interpret()");
        }
    }
}