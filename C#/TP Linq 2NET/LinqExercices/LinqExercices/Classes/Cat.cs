using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercices.Classes
{
	class Cat : Animal
	{
		public string FavoriteFish { get; set; }

		public Cat(string name, int age, string fish)
		{
			Name = name;
			Age = age;
			FavoriteFish = fish;
		}

		public override string ToString()
		{
			return $"{Name} says 'miaou' I am {Age} and like {FavoriteFish} fish";
		}
	}
}
