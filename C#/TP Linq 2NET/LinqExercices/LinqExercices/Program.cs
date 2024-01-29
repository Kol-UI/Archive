using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExercices.Classes;

namespace LinqExercices
{
	class Program
	{
		public static List<Animal> Animals = new List<Animal>();
		static void Main(string[] args)
		{
			List<Dog> dogs = new List<Dog> {
				new Dog("Pan", 5, "turkey"), new Dog("Milo", 1, "lamb"),
				new Dog("Clyde", 2, "beef"), new Dog("Goldie", 1, "chicken"),
				new Dog("Rusty", 2, "turkey"), new Dog("Lips", 6, "chicken")
			};

			List<Cat> cats = new List<Cat> {
				new Cat("Monty", 5, "american sole"), new Cat("Marmalade", 1, "angelfish"),
				new Cat("Cole", 2, "blenny"), new Cat("Honey Bee", 1, "blackfish"),
				new Cat("Venus", 2, "inanga"), new Cat("Lil Bub", 6, "blenny")
			};

			Animals.AddRange(dogs);
			Animals.AddRange(cats);

			#region TP 1

			//Console.WriteLine("Get only dogs:");
			//foreach (var dog in GetAllDogs())
			//	Console.WriteLine(dog);

			//Console.WriteLine("\nGet only cats:");
			//foreach (var cat in GetAllCats())
			//	Console.WriteLine(cat);

			//Console.WriteLine("\nGet only even aged ones:");
			//foreach (var animal in GetEvenAgedOnes())
			//	Console.WriteLine(animal);

			//Console.WriteLine("\nGet a random animal:");
			//Console.WriteLine(GetRandom()); 

			#endregion

			#region TP 2

			Animals.Sort(new AnimalComparer());
			foreach (var animal in Animals)
				Console.WriteLine(animal);	

			#endregion

			Console.WriteLine("Press any keys to exit...");
			Console.ReadKey();
		}

		public static List<Dog> GetAllDogs()
		{
			IEnumerable<Dog> results = from animal in Animals
									       where animal is Dog
									       select (Dog)animal;
			return results.ToList();
		}

		public static List<Cat> GetAllCats()
		{
			IEnumerable<Cat> results = from animal in Animals
									   where animal is Cat
									   select (Cat)animal;
			return results.ToList();
		}

		public static List<Animal> GetEvenAgedOnes()
		{
			IEnumerable<Animal> results = from animal in Animals
										  where animal.Age % 2 == 0
										  select animal;
			return results.ToList();
		}

		public static Animal GetRandom()
		{
			Random random = new Random();
			return Animals[random.Next(0, Animals.Count)];
		}
	}
}
