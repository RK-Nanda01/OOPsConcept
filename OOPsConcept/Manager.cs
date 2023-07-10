using System;
namespace OOPsConcept
{
	public class Manager : Employee
	{
		private
			int ssnNumber;

		public Manager(string name , int age, int ssn) : base( name,  age)
        {
			this.name = name;
			this.age = age;
			this.ssnNumber = ssn;
		}

		public void GetManagerDetails()
		{
			this.GetDeatils();
			Console.WriteLine($"The SSN of Manager is {ssnNumber}");
		}
	}
}

