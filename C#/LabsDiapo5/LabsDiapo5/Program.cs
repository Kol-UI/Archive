using System;

namespace LabsDiapo5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog("Danko", 8, "marrow");
            Console.WriteLine(d);
            d.HaveBirthday();
            Console.WriteLine(d);

        }

    }
}
