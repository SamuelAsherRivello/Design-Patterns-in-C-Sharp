//The Concrete state classes implement various behaviors, associated with a state of the Context.
namespace DesignPatterns.BehavioralPatterns.StatePattern 
{
    
    public class ConcreteStateA : IState 
    {
        public void Handle(Context context) {
            context.State = new ConcreteStateB();
        }
    }
    
    public class ConcreteStateB : IState 
    {
        public void Handle(Context context) {
            context.State = new ConcreteStateA();
        }
    }
}