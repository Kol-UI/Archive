namespace EnumerableClasses
{
    public class MyEnumeration
    {
        public static readonly MyEnumeration Value1 = new MyEnumeration(1, "Value 1");
        public static readonly MyEnumeration Value2 = new MyEnumeration(2, "Value 2");
        public static readonly MyEnumeration Value3 = new MyEnumeration(3, "Value 3");

        public int Id { get; }
        public string Name { get; }

        private MyEnumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Optionally, you can override ToString() for better string representation
        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}