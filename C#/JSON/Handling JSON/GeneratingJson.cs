using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        var person = new Person
        {
            Name = "Alice",
            Age = 25,
            Email = "alice@example.com",
            IsDeveloper = false,
            Languages = new[] { "Java", "C++", "Swift" }
        };

        string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
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

{
  "Name": "Alice",
  "Age": 25,
  "Email": "alice@example.com",
  "IsDeveloper": false,
  "Languages": [
    "Java",
    "C++",
    "Swift"
  ]
}
*/