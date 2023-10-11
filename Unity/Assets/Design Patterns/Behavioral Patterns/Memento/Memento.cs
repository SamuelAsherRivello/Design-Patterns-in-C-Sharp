//The Mememto is the one that will be used to store the data.

namespace DesignPatterns.BehavioralPatterns.MementoPattern
{
    public class Memento
    {
        //store the data in the constructor
        public Memento(SampleData data)
        {
            Data = data;
        }

        public SampleData Data { get; set; }
    }
}