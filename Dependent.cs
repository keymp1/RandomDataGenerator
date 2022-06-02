
using System;
namespace RandomDataGenerator
{
	public class Dependent : Person
	{
		//Dependent class that inherits from person
		public Dependent() : base()
		{
			Random randy = new Random();
			Birthday = DateTime.Now.AddYears(randy.Next(11));
			Birthday.AddMonths(randy.Next(12));
		}

		
	}
}
