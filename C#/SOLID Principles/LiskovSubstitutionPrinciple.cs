public class Bird
{
    public virtual void Fly() { }
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        // Implementation for flying
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Ostriches cannot fly.");
    }
}