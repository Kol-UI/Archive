using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercices.Classes
{
	abstract class Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public void HaveBirthday() { Age += 1; }
	}
}
