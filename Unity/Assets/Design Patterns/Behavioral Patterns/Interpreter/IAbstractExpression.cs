//The Abstract Expression is the one that will be used to interpret the context.
namespace DesignPatterns.BehavioralPatterns.InterpreterPattern
{
    public interface IAbstractExpression {
        void Interpret(Context context);
    }
}

