// Example 2: Extension method to calculate the factorial of an integer
public static class IntegerExtensions
{
    public static int Factorial(this int number)
    {
        if (number == 0)
            return 1;
        return number * Factorial(number - 1);
    }
}