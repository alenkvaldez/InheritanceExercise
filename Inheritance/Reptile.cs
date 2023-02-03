using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			isExtinct = false;
			Eyes = 2;
			Legs = 4;
			Class = "Reptilia";

        }
		public bool Scales { get; set; }
		public bool ColdBlooded { get; set; }
		public string Diet { get; set; }
		public bool CanGrowTail { get; set; }
	}
}

