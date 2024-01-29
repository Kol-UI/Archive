using System;
using TempoProject.Classes;
using TempoProject.Services;

namespace TempoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var Test = new Sample
            {
                Name = "MyTest",
                Type = MyType.Spring,
                Meter = MeterType.Waters.UsageWater,
            };

            IInterfaceSample service = new ImplementationClass();
            service.SampleMethod();

        }

        public static void Calculate(int a, int b)
        {
            int result = a + b;
        }
    }
}