using System;
using System.Threading;

class Program
{
    static object ResourceA = new object();
    static object ResourceB = new object();

    static void Thread1()
    {
        lock (ResourceA)
        {
            Console.WriteLine("Thread1 acquired ResourceA");
            Thread.Sleep(100); // Simulating some work

            lock (ResourceB)
            {
                Console.WriteLine("Thread1 acquired ResourceB");
            }
        }
    }

    static void Thread2()
    {
        lock (ResourceB)
        {
            Console.WriteLine("Thread2 acquired ResourceB");
            Thread.Sleep(100); // Simulating some work

            lock (ResourceA)
            {
                Console.WriteLine("Thread2 acquired ResourceA");
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Program completed successfully.");
    }
}