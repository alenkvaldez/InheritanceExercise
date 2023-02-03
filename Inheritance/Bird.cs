using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			isExtinct = false;
			Eyes = 2;
			Legs = 2;
			Class = "Aves";
		}

		public bool Feathers { get; set; }
		public bool WarmBlooded { get; set; }
		public string Diet { get; set; }
		public double BeakLength { get; set; }
	}
}

