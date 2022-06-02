using System.Collections;

using System;
namespace RandomDataGenerator
{
	public class Person
	{

		Random randy = new Random();
		string[] _arrayOfFirstNames = new string[] { "Jim", "Jeff", "Joffrey", "Jalen", "Jeorge", "Jimothy", "Jerrod", "Jocephus", "Jordan", "James" };
		ArrayList _dependents = new ArrayList(10);

		public string FirstName { get; init; }


		public string LastName { get; init; }

		public DateTime Birthday { get; init; }

		public SSN SSN { get; init; }

		public Phone Phone { get; init; }

		//person constructor
		public Person()
		{
			FirstName = _arrayOfFirstNames[randy.Next(_arrayOfFirstNames.Length)];
			var lastNames = Enum.GetValues(typeof(LastName));
			var value = lastNames.GetValue(randy.Next(_arrayOfFirstNames.Length));
			LastName = value.ToString();
			SSN = new SSN();
			//https://www.codegrepper.com/code-examples/csharp/c%23+generate+random+date+of+birth+but+over+18
			var birthday = new DateTime(2004, 6, 1);
			int range = (DateTime.Today - birthday).Days;
			Birthday = birthday.AddDays(randy.Next(range));
			Phone = new Phone();
			List<Dependent>[] _dependents = new List<Dependent>[10];

		}
		// age method to show age as int
		public int Age ()
        {
			 TimeSpan age = DateTime.Today - Birthday;




			return age.Days/365;
        }

		// method to add dependent to _dependents list
		public void AddDependent()
		{
			_dependents.Add(new Dependent());
		}
		//formatted toString method
		public override String ToString()
        {
			return			 (FirstName + "\n" +
							  LastName + "\n" +
							  Birthday + "\n" +
							  Age() + "\n" +
							  SSN + "\n" +
							  Phone + "\n" +
							  "Dependents:" + _dependents
							  );
        }





	}
}

