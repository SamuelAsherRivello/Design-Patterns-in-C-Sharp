//The Facade class provides a simple interface to a complex subsystem.
namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class Facade
    {
        private SubSystem1 _subSystem1;
        private SubSystem2 _subSystem2;
        
        public Facade(SubSystem1 subSystem1, SubSystem2 subSystem2)
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
        }
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += _subSystem1.Operation1();
            result += _subSystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _subSystem1.OperationN();
            result += _subSystem2.OperationZ();
            return result;
        }
    }
}