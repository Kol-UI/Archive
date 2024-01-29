using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercices.Classes
{
	class Dog : Animal
	{
		public string FavoriteBone { get; set; }
		
		public Dog(string name, int age, string bone)
		{
			Name = name;
			Age = age;
			FavoriteBone = bone;
		}

		public override string ToString()
		{
			return $"{Name} says 'woof' I am {Age} and like {FavoriteBone} bones";
		}
	}

}
