public interface IWorker
{
    void Work();
}

public interface IFeeder
{
    void Eat();
}

public class HumanWorker : IWorker, IFeeder
{
    public void Work()
    {
        // Working
    }

    public void Eat()
    {
        // Eating
    }
}

public class RobotWorker : IWorker {
    public void Work() {
        // Working
    }
}