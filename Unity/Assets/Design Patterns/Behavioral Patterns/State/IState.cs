//The IState interface declares a method for executing a state-specific behavior.

namespace DesignPatterns.BehavioralPatterns.StatePattern
{
    public interface IState
    {
        void Handle(Context context);
    }
}