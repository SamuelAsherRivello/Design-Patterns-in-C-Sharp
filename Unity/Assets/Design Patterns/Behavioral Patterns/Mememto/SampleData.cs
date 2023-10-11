//The sample data struct will store data that will be used by the Memento.
using UnityEngine;

namespace DesignPatterns.BehavioralPatterns.MementoPattern
{
    [SerializeField]
    public struct SampleData
    {
        public int Data1 { get; set; }
        public string Data2 { get; set; }

    }
}