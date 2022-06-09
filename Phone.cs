using System;
using System.Text.RegularExpressions;

namespace RandomDataGenerator

{

	public class Phone
	{

		public String Number { get; init; }
		public Phone()
		{
			Number = Format();
		}

		public string Format(char seperator = '-')
		{
			var randomNumbers = new int[10];
			Random randy = new Random();

			string phoneNumber = "";

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				randomNumbers[i] = randy.Next(10);
			}

			while (randomNumbers[0] == 0)
			{
				randomNumbers[0] = randy.Next(10);
			}

			foreach (int i in randomNumbers)
			{
				phoneNumber = String.Concat(phoneNumber, i);

			}

			phoneNumber = phoneNumber.Insert(3, seperator.ToString());
			phoneNumber = phoneNumber.Insert(7, seperator.ToString());
			return phoneNumber;






		}

        public override string ToString()
        {
            return Number;
        }


    }
}
