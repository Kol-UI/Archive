// Example 1: Extension method to capitalize the first letter of a string
public static class StringExtensions
{
    public static string CapitalizeFirstLetter(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}