﻿
using Fare;

namespace RandomDataGenerator
{

	public class SSN
	{
		public string Number { get; init; }

		public SSN()
		{
			// Patterns for invalid SSN(s).
			//https://primepay.com/blog/how-determine-valid-social-security-number

			Number = ToString();

		}

		public String ToString()
		{

			var randomNumbers = new int[9] {6,6,6,0,0,0,0,0,0};
			Random randy = new Random();

			string socSecNum = "";

			for (int i = 0; i < 6; i++)
			{
				randomNumbers[3] = randy.Next(6);
			}

			

			foreach (int i in randomNumbers)
			{
				socSecNum = String.Concat(socSecNum, i);

			}

			char seperator = '-';
			socSecNum = socSecNum.Insert(3, seperator.ToString());
			socSecNum = socSecNum.Insert(7, seperator.ToString());
			return socSecNum;
		}
	}
}