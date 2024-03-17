using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = @"{
            ""name"": ""John Doe"",
            ""age"": 30,
            ""email"": ""john@example.com"",
            ""isDeveloper"": true,
            ""languages"": [""C#"", ""JavaScript"", ""Python""]
        }";

        Person person = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Email: {person.Email}");
        Console.WriteLine($"Is Developer: {person.IsDeveloper}");
        Console.WriteLine("Languages:");
        foreach (var lang in person.Languages)
        {
            Console.WriteLine($" - {lang}");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool IsDeveloper { get; set; }
    public string[] Languages { get; set; }
}

/*
Output :

Name: John Doe
Age: 30
Email: john@example.com
Is Developer: True
Languages:
 - C#
 - JavaScript
 - Python
*/