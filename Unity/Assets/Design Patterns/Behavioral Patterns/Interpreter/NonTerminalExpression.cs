// A Nonterminal Expression is one that contains other expressions.

namespace DesignPatterns.BehavioralPatterns.InterpreterPattern
{
    public class NonTerminalExpression : IAbstractExpression
    {
        private readonly IAbstractExpression _expression1;
        private readonly IAbstractExpression _expression2;

        public NonTerminalExpression(IAbstractExpression expression1, IAbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public void Interpret(Context context)
        {
            _expression1.Interpret(context);
            _expression2.Interpret(context);
        }
    }
}