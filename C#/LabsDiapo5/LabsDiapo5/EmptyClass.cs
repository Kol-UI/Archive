using System;


namespace LabsDiapo5
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        public string FavoriteBone { get; set; }
        public void HaveBirthday() { Age += 1; }
        public override string ToString()
        {
            return string.Format(
            "{0} says 'woof' I am {1} and like " +
            "{2} bones", Name, Age, FavoriteBone
        );
        }
        public Dog(string name, int age, string bone)
        {
            Name = name;
            Age = age;
            FavoriteBone = bone;
        }
    }
}