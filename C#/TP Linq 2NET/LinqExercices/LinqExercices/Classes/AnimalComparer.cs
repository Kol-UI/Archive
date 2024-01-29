using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercices.Classes
{
	class AnimalComparer : IComparer<Animal>
	{
		public int Compare(Animal x, Animal y)
		{
			if (x is Dog && y is Cat)
				return -1;
			if (x is Cat && y is Dog)
				return 1;
			if (x.Age != y.Age)
				return x.Age - y.Age;
			return x.Name[0] - y.Name[0];
		}
	}
}
