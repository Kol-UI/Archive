using System;
namespace TempoProject.Services
{
    interface IInterfaceSample
    {
        void SampleMethod();
    }

    class ImplementationClass : IInterfaceSample
    {
        // Explicit interface member implementation:
        void IInterfaceSample.SampleMethod()
        {
            Console.WriteLine("test");
        }
    }
}

