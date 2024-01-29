using System;
using System.Collections.Generic;

namespace DataStructureDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Create A Dictionary ---");
            // Create
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"India","Mumbai, New Delhi, Pune"}
            };
            // Print
            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Create
            Dictionary<int, string> numberNames = new()
            {
                { 1, "One" },
                { 3, "Three" },
                { 2, "Two" }
            };

            Console.WriteLine("--- Add In Dictionary ---");
            // Add
            AddInDictionary.AddingValues(numberNames);
            // Print
            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("--- Check In Dictionary ---");
            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
            //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            // Check Element
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }
            else
            {
                Console.WriteLine("Key/Value does not exist");
            }

            Console.WriteLine("--- Check for input, Enter a Country Name ---");
            string? input = Console.ReadLine();
            if (cities.ContainsKey(input))
            {
                Console.WriteLine(cities[input]);
            }
            else
            {
                Console.WriteLine("{0} does not exist", input);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("--- Access elements using for loop ---");
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }


            Console.WriteLine("--- Update elements ---");
            // Update
            cities["UK"] += "Liverpool, Bristol"; // update value of UK key, adding values
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key, erasing old values
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }


            Console.WriteLine("--- Remove element ---");
            Console.WriteLine("Total Elements: {0}", cities.Count);

            Console.WriteLine("Remove UK:");
            if (cities.ContainsKey("UK"))
            {
                cities.Remove("UK");
            }
            Console.WriteLine("Total Elements: {0}", cities.Count);

            Console.WriteLine("--- Clear dictionary ---");
            cities.Clear(); //deletes all elements
            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

        }
    }
}
