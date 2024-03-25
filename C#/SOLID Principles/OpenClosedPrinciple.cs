public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area() => Math.PI * Math.Pow(Radius, 2);
}

public class Square : Shape
{
    public double Length { get; set; }

    public override double Area() => Math.Pow(Length, 2);
}