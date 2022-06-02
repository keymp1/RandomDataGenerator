
using System;
namespace RandomDataGenerator
{
	public class Dependent : Person
	{
		public Dependent() : base()
		{
			Random randy = new Random();
			Birthday = DateTime.Now.AddYears(randy.Next(11));
			Birthday.AddMonths(randy.Next(12));
		}

		
	}
}
